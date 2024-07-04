using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using SFB;
using UnityEditor;
using UnityEngine;
using System.Linq;
using Debug = UnityEngine.Debug;

namespace FizzSDK.QuickAssetMigrator
{
    public class QuickAssetMigratorEditor : EditorWindow, IHasCustomMenu
    {
        private const string AssetMigratorRepository = "https://github.com/Fizzyhex/asset_migrator_extsdk";
        
        private bool _shouldMigrateScripts = false;
        private bool _shouldMigrateShaders = false;
        private string _migratorArguments = "";
        private bool _isAssetMigratorPresent = true;
        private bool _isFocused;
        private bool _hasMigrated = false;
        
        [MenuItem("Tools/Quick Asset Migrator")]
        public static void ShowWindow()
        {
            GetWindow<QuickAssetMigratorEditor>("Quick Asset Migrator");
        }

        void IHasCustomMenu.AddItemsToMenu(GenericMenu menu)
        {
            GUIContent content = new("Open Asset Migrator Repository");
            menu.AddItem(content, false, () => Application.OpenURL(AssetMigratorRepository));
        }

        private static string GetWorkingDirectory()
        {
            return Application.dataPath.Replace("/", @"\") + @"\QuickAssetMigrator";
        }
        
        private static string[] GetExtensions()
        {
            var extensionOverrides = $@"{GetWorkingDirectory()}\extensions.txt";

            return System.IO.File.Exists(extensionOverrides)
                ? System.IO.File.ReadAllLines(extensionOverrides)
                : new[] { "prefab", "unity", "mat", "asset", "controller" };
        }

        private static bool CheckForAssetMigrator()
        {
            var workingDirectory = GetWorkingDirectory();
            var assetMigratorPath = $@"{workingDirectory}\asset_migrator.exe";
            return System.IO.File.Exists(assetMigratorPath);
        }
        
        private static void MoveDirectoryDestructive(string source, string target) {
            if (Directory.Exists(target)) {
                Directory.Delete(target, true);
            }

            Directory.Move(source, target);
        }

        private void OnGUI()
        {
            var wasFocused = _isFocused;
            _isFocused = (focusedWindow == this);

            if (wasFocused != _isFocused)
            {
                _isAssetMigratorPresent = CheckForAssetMigrator();
            }
            
            if (!_isAssetMigratorPresent)
            {
                EditorGUILayout.BeginVertical(GUI.skin.box);
                EditorGUILayout.HelpBox("asset_migrator.exe is missing! Please drag it underneath Assets/QuickAssetMigrator in your project.", MessageType.Error);

                if (GUILayout.Button("Open Repository"))
                {
                    Application.OpenURL(AssetMigratorRepository);
                }
                
                EditorGUILayout.EndVertical();
                EditorGUILayout.Space();
                EditorGUI.BeginDisabledGroup(true);
            }
            
            if (GUILayout.Button("Select Assets"))
            {
                var targetExtensions = new[]
                {
                    new ExtensionFilter("Assets", GetExtensions())
                };
                
                var paths = StandaloneFileBrowser.OpenFilePanel("Select Assets", "", targetExtensions, true);

                if (paths.Length > 0)
                {
                    _migratorArguments = string.Join(" ", MakeMigrationArgs(paths));
                }
            }

            EditorGUILayout.Space();
            EditorGUILayout.LabelField("File Export Settings", EditorStyles.boldLabel);
            
            _shouldMigrateScripts = EditorGUILayout.Toggle("Migrate Scripts", _shouldMigrateScripts);
            _shouldMigrateShaders = EditorGUILayout.Toggle("Migrate Shaders", _shouldMigrateShaders);
            
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Migration", EditorStyles.boldLabel);
            
            EditorGUILayout.BeginVertical(GUI.skin.box);
            EditorGUILayout.LabelField("Generated Arguments");
            
            _migratorArguments = EditorGUILayout.TextArea(text: _migratorArguments,
                new GUIStyle(EditorStyles.textField) { wordWrap = true });
            
            EditorGUILayout.EndVertical();
                
            EditorGUI.BeginDisabledGroup(_migratorArguments.Length == 0);
            
            const string conversionOutputFolderName = "ConversionOutput";
            const string conversionOutputPath = "Assets/QuickAssetMigrator/ConversionOutput";
            
            if (GUILayout.Button("Migrate!"))
            {
                var workingDirectory = GetWorkingDirectory();
                Debug.Log("CWD:"+workingDirectory);
                    
                var startInfo = new ProcessStartInfo
                {
                    FileName = workingDirectory + @"\asset_migrator.exe",
                    Arguments = _migratorArguments,
                    UseShellExecute = false,
                    WorkingDirectory = workingDirectory
                };
                
                Debug.Log($"Running asset migrator with arguments: {_migratorArguments}");
                var process = Process.Start(startInfo);
                process?.WaitForExit();

                var conversionOutput = $"{workingDirectory}\\{conversionOutputFolderName}";

                if (!_shouldMigrateScripts)
                {
                    var csFiles = Directory.GetFiles(conversionOutput, "*.cs", SearchOption.AllDirectories);
                    foreach (var file in csFiles)
                    {
                        File.Delete(file);
                    }
                }

                if (!_shouldMigrateShaders)
                {
                    var shaderFiles = Directory.GetFiles(conversionOutput, "*.shader", SearchOption.AllDirectories);
                    foreach (var file in shaderFiles)
                    {
                        File.Delete(file);
                    }
                }
                
                var folderObject = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(conversionOutputPath);
                EditorUtility.FocusProjectWindow();
                AssetDatabase.OpenAsset(folderObject);

                _hasMigrated = true;
            }
            
            EditorGUI.EndDisabledGroup();

            if (_hasMigrated)
            {
                EditorGUILayout.LabelField($"Outputted to {conversionOutputPath}!");
            }
        }

        private static string[] MakeMigrationArgs(IReadOnlyList<string> paths)
        {
            var ripAssetsFolder = FindAssetsFolder(paths[0]);

            if (ripAssetsFolder.Length == 0)
            {
                Debug.LogError("Could not find the 'Assets' folder in the ancestry of the selected files.");
                return Array.Empty<string>();
            }
            
            // note: asset migrator requires double quotes instead of single quotes, otherwise it'll panic and
            // say the paths are invalid!
            
            var unityAssetsFolder = Application.dataPath.Replace("/", @"\");
            var escapedPaths = paths.Select(path => $"\"{path}\"");
            
            string[] arguments = {$"\"{ripAssetsFolder}\"", $"\"{unityAssetsFolder}\""};
            arguments = arguments.Concat(escapedPaths).ToArray();
            
            return arguments;
        }

        private static string FindAssetsFolder(string path)
        {
            while (true)
            {
                var lastSlashIndex = path.LastIndexOf(@"\", StringComparison.Ordinal);

                if (lastSlashIndex == -1)
                {
                    return "";
                }
                
                path = path[..lastSlashIndex];
                
                if (path.EndsWith(@"\Assets"))
                {
                    return path;
                }
            }
        }
    }
}