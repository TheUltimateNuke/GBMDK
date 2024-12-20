using GB.UI.Menu;
using UnityEngine;
using UnityEngine.UI;

namespace Costumes
{
	public class CostumeSaveUI : MonoBehaviour
	{
		public CostumeCustomization CostumeCustomization;

		public MenuNotification MenuNotification;

		public GameObject SaveListContainer;

		public SaveSelection SaveSelection;

		public GameObject CostumePartsButtonsGO;

		public GameObject ButtonsContainer;

		public Button SaveButton;

		public Button SaveSelectionButton;

		public EnterCloudCodeUI EnterCloudCodeUi;

		public ConfermationModal ConfermationPreFab;

		public ControllerButtons[] ControllerButtons;

		private bool _saveEdited;

		private int? _saveIndex;

		private Button _lastButtonPressed;

		public CostumeUISaveLoad CostumeUiSaveLoad;

		[SerializeField]
		private MenuController _MC;

		[SerializeField]
		private BaseMenuScreen _Prompt;

		[SerializeField]
		private VoiceBubble _voiceBubble;

		private CostumeSaveEntry _costumeCache;

		public bool NeedsSave => false;

		public int? SaveIndex()
		{
			return null;
		}

		public void Awake()
		{
		}

		private void OnCostumeChanged()
		{
		}

		public void SaveEdited()
		{
		}

		public void ActivateSave(int? index)
		{
		}

		public void SetLastButtonPressed(Button lastButtonPressed)
		{
		}

		public void Confirm(ConfermationModal.Callback callback, string title, string body = "")
		{
		}

		public void BackAction()
		{
		}

		public void SaveAction()
		{
		}

		public void AddSave()
		{
		}

		public void CheckForModifications()
		{
		}

		public void DeleteSave()
		{
		}

		public void ConfirmDelete(bool accept)
		{
		}

		public virtual void DeleteSaveConfirmed()
		{
		}
	}
}
