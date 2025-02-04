using System.IO;
using UnityEditor;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine.AddressableAssets;

public class BuildShortcut
{
    [MenuItem("Tools/GBMDK/Build Addressable Content", priority = 10)]
    public static void OnTrigger()
    {
        Directory.Delete(Addressables.BuildPath, true);
        AddressableAssetSettings.BuildPlayerContent();
    }
}
