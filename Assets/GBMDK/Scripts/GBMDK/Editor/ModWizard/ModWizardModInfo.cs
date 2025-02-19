using UnityEngine;

namespace GBMDK.Editor
{
    public class ModWizardModInfo : ScriptableObject
    {
        [HideInInspector]
        public bool currentlyActive;
        public ModWizardModInfo_Refs refs;
    }
}