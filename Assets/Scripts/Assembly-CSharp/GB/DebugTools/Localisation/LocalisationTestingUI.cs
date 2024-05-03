using System.Collections.Generic;
using GB.Data.Language;
using TMPro;
using UnityEngine;

namespace GB.DebugTools.Localisation
{
	public class LocalisationTestingUI : MonoBehaviour
	{
		public LocalisationStringContextSet _set;

		public LanguageDatabase _languageDatabase;

		public LocalisationTesting _tester;

		public TMP_Dropdown _languageDropdown;

		public TMP_Dropdown _setDropdown;

		public TMP_Dropdown _stringDropdown;

		public TMP_Dropdown _modalDropdown;

		public TMP_Text _defaultModalDisplayText;

		public TMP_Text _defaultInfo;

		public TMP_Text _defaultEnglishText;

		public TMP_Text _defaultLanguageText;

		private int _selectedLanguage;

		private int _selectedString;

		private int _selectedModal;

		public RectTransform[] _updateTransforms;

		private List<string> sorts;

		private static bool _isOpen;

		private List<LocalisationStringContext> _contexts;

		private List<LocalisationStringContext> _sortContexts;

		private static GameObject lastSelected;

		private static GameObject localisationTesting;

		public static void ToggleLocalisationScene(LocalisationStringContextSet _set)
		{
		}

		public static void LoadLocalisationScene(LocalisationStringContextSet _set)
		{
		}

		public static void CloseLocalisationScene(LocalisationStringContextSet _set)
		{
		}

		public List<string> GetSorts()
		{
			return null;
		}

		private void Awake()
		{
		}

		private void UpdateString()
		{
		}

		private void SetupStringDropdown()
		{
		}

		public List<LocalisationStringContext> LoadStrings(int sort)
		{
			return null;
		}

		public void DisplayStringWithModel()
		{
		}

		public void NextString()
		{
		}

		public void PreviousString()
		{
		}

		private void SelectString(int i)
		{
		}

		private void UpdateTransforms()
		{
		}
	}
}
