using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GB.UI.Utils.Settings
{
	public class LocalizedInputMapHandeler : MonoBehaviour
	{
		[SerializeField]
		public List<LocalizedInputMap> _inputMap;

		[SerializeField]
		private List<LocalizedTextReplacer> _mapTextFieldComponents;

		[SerializeField]
		private Image _overrideImage;

		public int CurrentMapIndex;

		public const int DefaultMapIndex = 0;

		public int TESTINGMAPTOLOAD;

		private void Awake()
		{
		}

		[ContextMenu("DEBUG: LOAD")]
		public void TESTINGLOAD()
		{
		}

		public void LoadInputMap(int Index)
		{
		}

		[ContextMenu("Find All Inputs")]
		public void FindAllInputs()
		{
		}
	}
}
