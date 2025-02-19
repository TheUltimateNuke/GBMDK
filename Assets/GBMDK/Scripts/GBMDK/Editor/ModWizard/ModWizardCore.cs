using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
using UnityEditor.AddressableAssets.Settings.GroupSchemas;
using UnityEngine;

namespace GBMDK.Editor
{
    public static class ModWizardCore
    {
        public static readonly string BaseModsAssetFolderPath = Path.GetRelativePath(Path.Combine(Application.dataPath, ".."), Path.Combine(Application.dataPath, "Mods"));
        public static readonly Dictionary<ModWizardModInfo, ModWizardModInfo_Refs> Mods = new();

        /// <summary>
        /// Creates a new Addressable group by passed name and returns it, or returns the existing group with that name.
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="removeExisting"></param>
        /// <returns>A new Addressable group with the passed name, or the existing group with that name.</returns>
        private static AddressableAssetGroup CreateAddressableGroup(string groupName, bool removeExisting = false)
        {
            var settings = AddressableAssetSettingsDefaultObject.Settings;

            if (settings != null)
            {
                var group = settings.FindGroup(groupName);
                if (group != null)
                {
                    if (removeExisting) settings.RemoveGroup(group);
                    else
                    {
                        Debug.LogWarning($"Cannot create new Addressable group: Group with name \"{groupName}\" already exists! Returning existing group. . .");
                        return group;
                    }
                }

                group = settings.CreateGroup(groupName, false, false, true, null, typeof(ContentUpdateGroupSchema), typeof(BundledAssetGroupSchema));

                return group;
            }

            Debug.LogError("Addressable Asset Settings are null! Are Addressables initialized in the editor?");
            return null;
        }

        public static ModWizardModInfo CreateMod(string name = "")
        {
            if (string.IsNullOrWhiteSpace(name))
                name = $"NewMod_{Mods.Count}";

            var newModInfo = ScriptableObject.CreateInstance<ModWizardModInfo>();
            newModInfo.name = name;


            var newGroup = CreateAddressableGroup(name);
            if (newGroup == null)
                throw new System.Exception($"Failed to create mod with name \"{name}\": {nameof(CreateAddressableGroup)} returned null!");

            var newModRefs = ScriptableObject.CreateInstance<ModWizardModInfo_Refs>();
            newModRefs.addressablesGroup = newGroup;
            newModRefs.assetsFolderPath = Path.Combine(BaseModsAssetFolderPath, name);

            newModInfo.refs = newModRefs;

            var modWizardDataPath = Path.Combine(newModRefs.assetsFolderPath, "ModWizardData");
            Directory.CreateDirectory(modWizardDataPath);
            AssetDatabase.Refresh();

            AssetDatabase.CreateAsset(newModInfo, AssetDatabase.GenerateUniqueAssetPath(Path.Combine(modWizardDataPath, $"{name}-Info.asset")));
            AssetDatabase.CreateAsset(newModRefs, AssetDatabase.GenerateUniqueAssetPath(Path.Combine(modWizardDataPath, $"{name}-Refs.asset")));

            EditorUtility.SetDirty(newModInfo);
            EditorUtility.SetDirty(newModRefs);

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            return newModInfo;
        }

        public static void RemoveMod(string name = "")
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                if (Mods.Count > 0)
                {
                    name = Mods.Last().Key.name;
                }
                else return; // No mods are here to remove, so just do nothing
            }


        }
    }
}