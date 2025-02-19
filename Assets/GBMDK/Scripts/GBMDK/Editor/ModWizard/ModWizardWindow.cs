using UnityEditor;
using UnityEngine;

namespace GBMDK.Editor
{
    public class ModWizardWindow : EditorWindow
    {
        private static ModWizardModInfo selectedModSettings;

        //[MenuItem("Tools/GBMDK/Mod Wizard", priority = 10)]
        public static ModWizardWindow OpenWindow()
        {
            var window = GetWindow<ModWizardWindow>("Mod Wizard");
            window.Show();

            return window;
        }

        private void OnAddButtonPressed()
        {
            ModWizardCore.CreateMod();
        }

        private void OnRemoveButtonPressed()
        {
            if (selectedModSettings != null)
            {

            }
        }

        private void OnGUI()
        {
            GUILayout.BeginVertical();

            GUILayout.BeginHorizontal();

            if (GUILayout.Button("Add", EditorStyles.toolbarButton))
            {
                OnAddButtonPressed();
            }

            if (GUILayout.Button("Remove", EditorStyles.toolbarButton))
            {
                OnRemoveButtonPressed();
            }

            GUILayout.EndHorizontal();

            if (ModWizardCore.Mods.Count > 0)
            {
                GUILayout.BeginScrollView(Vector2.zero);

                foreach (var mod in ModWizardCore.Mods.Keys)
                {
                    GUILayout.BeginHorizontal();

                    mod.currentlyActive = GUILayout.Toggle(mod.currentlyActive, "Set Active");
                    GUILayout.Label(mod.name, EditorStyles.boldLabel);

                    GUILayout.EndHorizontal();
                }

                GUILayout.EndScrollView();
            }
            else
            {
                GUILayout.Label("No mods found!\nCreate one with the \"Add\" button above.", EditorStyles.boldLabel);
            }

            GUILayout.EndVertical();
        }
    }
}