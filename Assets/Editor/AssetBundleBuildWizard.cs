using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.IO;

public class AssetBundleBuildWizard : EditorWindow
{
    [MenuItem("Window/Asset Management/Build Specific AssetBundle")]
    public static void ShowWindow()
    {
        GetWindow(typeof(AssetBundleBuildWizard));
    }

    private void OnGUI()
    {
        GUILayout.Label("Build Specific AssetBundle", EditorStyles.boldLabel);
        foreach (string bundleName in AssetDatabase.GetAllAssetBundleNames())
        {
            if (GUILayout.Button("Build " + bundleName))
            {
                Directory.CreateDirectory(Application.streamingAssetsPath);
                BuildAssetBundlesByName(new string[] { bundleName }, Application.streamingAssetsPath);
            }
        }
    }

    private static void BuildAssetBundlesByName(string[] assetBundleNames, string outputPath)
    {
        // Argument validation
        if (assetBundleNames == null || assetBundleNames.Length == 0)
        {
            return;
        }

        // Remove duplicates from the input set of asset bundle names to build.
        //assetBundleNames = assetBundleNames.Distinct().ToArray();

        List<AssetBundleBuild> builds = new List<AssetBundleBuild>();

        foreach (string assetBundle in assetBundleNames)
        {
            var assetPaths = AssetDatabase.GetAssetPathsFromAssetBundle(assetBundle);

            AssetBundleBuild build = new AssetBundleBuild();
            build.assetBundleName = assetBundle;
            build.assetNames = assetPaths;

            builds.Add(build);
            Debug.Log("assetBundle to build:" + build.assetBundleName);
        }

        BuildPipeline.BuildAssetBundles(outputPath, builds.ToArray(), BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
    }
}
