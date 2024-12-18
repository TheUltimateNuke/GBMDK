using UnityEditor;
using UnityEngine;

namespace GBMDK.Editor
{
    public class ShaderSwitcherWindow : EditorWindow
    {
        private Shader _toReplace;
        private Shader _replaceWith;

        [MenuItem("Window/GBMDK/Shader Switcher")]
        public static void ShowWindow() 
        {
            GetWindow<ShaderSwitcherWindow>(title: "Shader Switcher", utility: true);
        }
    }
}
