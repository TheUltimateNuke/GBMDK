using GB.Data.Loading;
using System.IO;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace GBMDK.Editor
{
    /*
    public class ContentStartersConfigWindow : EditorWindow
    {
        public GameObject[] SceneStarterObjects => _sceneStarterObjects.ToArray();
        [SerializeField]
        private List<GameObject> _sceneStarterObjects = new();

        [MenuItem("Tools/GBMDK/Content Starters Config")]
        public static void OpenWindow()
        {
            var window = GetWindow<ContentStartersConfigWindow>();
            window.titleContent = new GUIContent("Content Starters Config");
        }

        public void CreateGUI()
        {
            var serializedObject = new SerializedObject(this);
            var property = serializedObject.FindProperty(nameof(_sceneStarterObjects));
            serializedObject.Update();
            EditorGUILayout.PropertyField(property);
            serializedObject.ApplyModifiedProperties();
        }
    }
    */

    public class ContentStarters
    {
        private static void MarkAddressable(string assetPath, string assetAddress)
        {
            var settings = AddressableAssetSettingsDefaultObject.Settings;
            var entry = settings.CreateOrMoveEntry(AssetDatabase.AssetPathToGUID(assetPath), settings.DefaultGroup);
            entry.SetAddress(assetAddress);

            EditorUtility.SetDirty(settings);
            AssetDatabase.SaveAssets();
        }

        private static string GetCurrentSelectedPath()
        {
            var path = AssetDatabase.GetAssetPath(Selection.activeObject);
            if (path == "")
                path = "Assets";
            else if (Path.GetExtension(path) != "")
                path = path.Replace(Path.GetFileName(AssetDatabase.GetAssetPath(Selection.activeObject)), "");

            return path;
        }

        /*
        [MenuItem("Assets/GBMDK/Starters/Config")]
        public static void RouteToStartersConfig()
        {
            ContentStartersConfigWindow.OpenWindow();
        }
        */

        [MenuItem("Assets/GBMDK/Starters/Map Starter", priority = 10000)]
        public static void CreateMapStuff()
        {
            var path = GetCurrentSelectedPath();

            var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            var scenePath = AssetDatabase.GenerateUniqueAssetPath(Path.Combine(path, "NewMap.unity"));

            EditorSceneManager.SaveScene(newScene, scenePath);
            EditorSceneManager.CloseScene(newScene, false);

            MarkAddressable(scenePath, Path.GetFileNameWithoutExtension(scenePath));

            var sceneData = ScriptableObject.CreateInstance<SceneData>();
            sceneData.name = "NewMap-Data";
            sceneData._sceneRef = AddressableAssetSettingsDefaultObject.Settings.CreateAssetReference(Path.GetFileNameWithoutExtension(scenePath));
            var dataPath = AssetDatabase.GenerateUniqueAssetPath(Path.Combine(path, "NewMap-Data.asset"));
            AssetDatabase.CreateAsset(sceneData, dataPath);
            EditorUtility.SetDirty(sceneData);

            EditorUtility.FocusProjectWindow();
            
            MarkAddressable(dataPath, Path.GetFileNameWithoutExtension(dataPath));

            AssetDatabase.SaveAssets();
            Selection.activeObject = sceneData;
        }
    }
}