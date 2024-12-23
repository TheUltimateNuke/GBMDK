using UnityEditor;
using UnityEngine;

namespace GBMDK.Editor
{
    public class ShaderSwitcherWindow : EditorWindow
    {
        private Shader _toReplace;
        private Shader _replaceWith;

        [MenuItem("Tools/GBMDK/Shader Switcher")]
        public static void ShowWindow() 
        {
            GetWindow<ShaderSwitcherWindow>(title: "Shader Switcher", utility: true);
        }

        private void ReplaceShaders()
        {
            if (_toReplace == null || _replaceWith == null) return;

            foreach (var renderer in FindObjectsOfType<MeshRenderer>())
            {
                foreach (var material in renderer.materials)
                {
                    if (material.shader.name == _toReplace.name)
                    {
                        material.shader = _replaceWith;
                    }
                }
            }
        }

        private void OnGUI()
        {
            _toReplace = (Shader)EditorGUILayout.ObjectField("Shader to Replace", _toReplace, typeof(Shader), allowSceneObjects: false);
            _replaceWith = (Shader)EditorGUILayout.ObjectField("Replacement Shader", _replaceWith, typeof(Shader), allowSceneObjects: false);

            if (GUILayout.Button("Replace!"))
                ReplaceShaders();
        }
    }
}
