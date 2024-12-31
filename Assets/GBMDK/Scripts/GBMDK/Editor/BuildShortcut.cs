using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;

public class BuildShortcut
{
    [MenuItem("Tools/GBMDK/Build Addressable Content", priority = 10)]
    public static void OnTrigger() 
    {
        AddressableAssetSettings.BuildPlayerContent();
    }
}
