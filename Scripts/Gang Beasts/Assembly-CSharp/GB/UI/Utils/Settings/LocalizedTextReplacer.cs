using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

namespace GB.UI.Utils.Settings
{
	public class LocalizedTextReplacer : MonoBehaviour
	{
		[SerializeField]
		public List<LocalizedString> Texts;

		public string myText;

		public TextMeshProUGUI _target;

		public Text _targetText;

		private void Awake()
		{
		}

		private void ClearEvents()
		{
		}

		[ContextMenu("SETUP EVENTS")]
		private void SetupEvents()
		{
		}

		public void SetStringList(List<LocalizedString> newStrings)
		{
		}

		[ContextMenu("REFRSH")]
		public void RefreshText()
		{
		}

		public void UpdateTextFields(string newString)
		{
		}
	}
}
