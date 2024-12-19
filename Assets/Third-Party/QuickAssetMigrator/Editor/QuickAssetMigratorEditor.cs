using SFB;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace FizzSDK.QuickAssetMigrator
{
    public class QuickAssetMigratorEditor : EditorWindow, IHasCustomMenu
    {
        private const string AssetMigratorRepository = "https://github.com/Fizzyhex/asset_migrator_extsdk";
        
        private bool _shouldMigrateScripts;
        private bool _shouldMigrateShaders;
        private string _migratorArguments;
        private bool _isAssetMigratorPresent = true;
        private bool _isFocused;
        private bool _hasMigrated;
        private bool _infoFoldoutVisible;
        private string _sourceFolder;
        private List<string> _selectedAssets = new();
        
        [MenuItem("Window/GBMDK/Quick Asset Migrator")]
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

            if (GUILayout.Button("Select Source Folder"))
            {
                var path = StandaloneFileBrowser.OpenFolderPanel("Select Folder", "", false);

                if (path.Length > 0)
                {
                    _sourceFolder = path[0];
                }
            }

            if (_sourceFolder != null && _sourceFolder.Length > 0)
            {
                EditorGUILayout.BeginVertical(GUI.skin.box);
                EditorGUILayout.LabelField("Asset Selection", EditorStyles.boldLabel);
             
                GUILayout.Label($"Source: {_sourceFolder}");
                GUILayout.Label($"{_selectedAssets.Count} selected file(s)");
                
                if (GUILayout.Button("Add Assets"))
                {
                    var targetExtensions = new[]
                    {
                        new ExtensionFilter("Assets", GetExtensions())
                    };
                
                    var paths = StandaloneFileBrowser.OpenFilePanel("Select Assets", _sourceFolder, targetExtensions, true);

                    foreach (var path in paths)
                    {
                        if (_selectedAssets.Contains(path)) continue;
                        if (!IsInDirectory(path, _sourceFolder))
                        {
                            Debug.LogWarning($"Asset '{path}' was not added as it's not underneath source folder '{_sourceFolder}'!");
                            continue;
                        }

                        _selectedAssets.Add(path);
                    }
                }
            
                if (GUILayout.Button("Add Folder"))
                {
                    var paths = StandaloneFileBrowser.OpenFolderPanel("Select Folder", _sourceFolder, true);

                    foreach (var path in paths)
                    {
                        if (_selectedAssets.Contains(path)) continue;
                        if (!IsInDirectory(path, _sourceFolder))
                        {
                            Debug.LogWarning($"Folder '{path}' was not added as it's not underneath source folder '{_sourceFolder}'!");
                            continue;
                        }

                        _selectedAssets.Add(path);
                    }
                }
                
                EditorGUI.BeginDisabledGroup(_selectedAssets.Count == 0);
                if (GUILayout.Button("Clear Selection"))
                {
                    if (EditorUtility.DisplayDialog("Clear selected assets?", "Are you sure you want to clear the selected assets?", "Yes", "No"))
                    {
                        _selectedAssets.Clear();
                    }
                }
                EditorGUI.EndDisabledGroup();
            }

            GUILayout.EndVertical();
            
            EditorGUILayout.Space();
            
            EditorGUILayout.BeginVertical(GUI.skin.box);
            EditorGUILayout.LabelField("Export Settings", EditorStyles.boldLabel);
            
            _infoFoldoutVisible = EditorGUILayout.Foldout(_infoFoldoutVisible, "Information");
            if (_infoFoldoutVisible)
            {
                // not wrapping this line :3
                EditorGUILayout.HelpBox(
                    "If these boxes are un-ticked, content will be deleted upon Migration. If you're migrating ripped content, you likely want to leave 'keep shaders' and 'keep scripts' un-ticked, as you will only have access to dummy scripts/shaders.",
                    MessageType.Info);
                EditorGUILayout.EndFoldoutHeaderGroup();
            }
            
            _shouldMigrateScripts = EditorGUILayout.Toggle("Keep Scripts", _shouldMigrateScripts);
            _shouldMigrateShaders = EditorGUILayout.Toggle("Keep Shaders", _shouldMigrateShaders);
            
            EditorGUILayout.EndVertical();
            
            EditorGUILayout.Space();
            
            EditorGUILayout.BeginVertical(GUI.skin.box);
            EditorGUILayout.LabelField("Migration", EditorStyles.boldLabel);
            var migrationPressed = GUILayout.Button("Migrate!");
            
            if (GUILayout.Button("Copy arguments to clipboard"))
            {
                EditorGUIUtility.systemCopyBuffer = SplitMigratorArgs(MakeMigrationArgs(_sourceFolder, _selectedAssets));
                Debug.Log("Copied to clipboard!");
            }
            
            const string conversionOutputFolderName = "ConversionOutput";
            const string conversionOutputPath = "Assets/QuickAssetMigrator/ConversionOutput";
            
            if (migrationPressed)
            {
                var workingDirectory = GetWorkingDirectory();
                Debug.Log("CWD:" + workingDirectory);
                _migratorArguments = SplitMigratorArgs(MakeMigrationArgs(_sourceFolder, _selectedAssets));
                Debug.Log($"Running asset migrator with arguments: {_migratorArguments}");
                
                var startInfo = new ProcessStartInfo
                {
                    FileName = workingDirectory + @"\asset_migrator.exe",
                    Arguments = _migratorArguments,
                    UseShellExecute = false,
                    WorkingDirectory = workingDirectory
                };

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

            if (_hasMigrated)
            {
                EditorGUILayout.LabelField($"Outputted to {conversionOutputPath}!");
            }
            
            EditorGUILayout.EndVertical();
        }
        
        private static string SplitMigratorArgs(IReadOnlyList<string> args)
        {
            return string.Join(" ", args);
        }
        
        private static string[] MakeMigrationArgs(string sourceFolder, IReadOnlyList<string> paths)
        {
            // note: asset migrator requires double quotes instead of single quotes, otherwise it'll panic and
            // say the paths are invalid!
            
            var unityAssetsFolder = Application.dataPath.Replace("/", @"\");
            var escapedPaths = paths.Select(path => $"\"{path}\"");
            
            string[] arguments = {$"\"{sourceFolder}\"", $"\"{unityAssetsFolder}\""};
            arguments = arguments.Concat(escapedPaths).ToArray();
            Debug.Log(string.Join(" ", arguments));
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

        private static string FindFirstFolder(string path)
        {
            if (Directory.Exists(path)) return path;
            var lastSlashIndex = path.LastIndexOf(@"\", StringComparison.Ordinal);
            return lastSlashIndex == -1 ? "" : path[..lastSlashIndex];
        }

        private static bool IsInDirectory(string path, string directory)
        {
            return path.StartsWith(directory);
        }
    }
}