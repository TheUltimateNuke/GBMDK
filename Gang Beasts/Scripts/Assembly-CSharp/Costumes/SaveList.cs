using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Costumes
{
	public class SaveList : MonoBehaviour
	{
		public CostumeCustomization CostumeCustomization;

		public CostumeUISaveLoad CostumeUiSaveLoad;

		public CostumeSaveUI CostumeSaveUi;

		public MoveSelectedButtonTo MoveSelectedButtonTo;

		public Text SavesNumberText;

		public SaveButton SaveButton;

		public Button BackButton;

		private List<SaveButton> _saveButtons;

		private int? _saveSelectedIndex;

		public void Activate()
		{
		}

		public void SetSelectedIndex(int? index)
		{
		}

		public void SelectLastButton()
		{
		}

		public bool CreateSaveItems()
		{
			return false;
		}

		public void CleanSaveItems()
		{
		}

		public SaveButton CreateSaveSlotButton(string text, int? index)
		{
			return null;
		}

		public void SaveSlotClickAction(int? index)
		{
		}

		public void SaveSlotCancelPressed()
		{
		}

		public void SaveSlotSelected(int? index)
		{
		}

		private void PointerSelect(SaveButton saveButton)
		{
		}

		public virtual void LoadAction()
		{
		}

		private List<Button> SaveButtonToButton()
		{
			return null;
		}
	}
}
