using System;
using System.Collections.Generic;
using GB.Platform.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

namespace GB.Input
{
	public class RemappingMenuManager : MonoBehaviour
	{
		[Serializable]
		public struct ActionToStringEntry
		{
			public string ActionPath;

			public string StringKey;

			public List<string> CompositeParts;

			public PlatformBools shouldSkip;

			public List<string> AllowedMatchingInputActionPaths;

			public List<string> DisallowedInputs;
		}

		public delegate void OnRebindComplete();

		public delegate void OnRebindCancelled();

		public class ModalManager
		{
			private Action<bool> onOpen;

			private Action onClose;

			private Dictionary<int, GameObject> modalPrefabs;

			private Transform parentTransform;

			private ModalWindow currentModal;

			private CanvasGroup backgroundFader;

			public bool isOpen { get; private set; }

			public ModalManager(Transform parentTransform, CanvasGroup backgroundFaderGroup, KeyValuePair<int, GameObject>[] modalPrefabs, Action<bool> onOpen, Action onClose)
			{
			}

			public void AddPrefab(ModalType type, GameObject prefab)
			{
			}

			public void OpenModal(ModalType type, string message, Action<UserResponse> userResponseCallback, Transform parent = null, CanvasGroup hider = null)
			{
			}

			public void CloseModal()
			{
			}

			public void UserCancelPressed()
			{
			}

			public void Reset()
			{
			}
		}

		public enum ModalType
		{
			NoButtons = 0,
			Okay = 1,
			ConfirmCancel = 2
		}

		public enum ControllerSetType
		{
			None = 0,
			Joystick = 1,
			Keyboard = 2,
			KeyboardAndMouse = 3
		}

		private const string remappingActionCategory = "Default";

		private const string remappingMapCategory = "Default";

		private const string remappingJoystickMapLayout = "Default";

		private const string remappingKeyboardMapLayout = "Default";

		private const string remappingMouseMapLayout = "Default";

		private const int userPauseMenuActionId = 16;

		private const int userConfirmActionId = 3;

		private const int userCancelActionId = 4;

		private const float inputDelayTime = 0.1f;

		public List<ActionToStringEntry> ActionToStringList;

		private InputActionRebindingExtensions.RebindingOperation m_RebindOperation;

		private List<InputBinding> m_CachedActionBindings;

		public float pollingDelayTime;

		[SerializeField]
		public CanvasGroup _uiGroup;

		[SerializeField]
		private Transform _modalParent;

		private ModalManager modalManager;

		private bool m_JustEnteredMenu;

		public GameObject defaultUIElement;

		public GameObject modalWindow_NoButtons_Prefab;

		public GameObject modalWindow_Okay_Prefab;

		public GameObject modalWindow_ConfirmCancel_Prefab;

		[SerializeField]
		private CanvasGroup _hideOnModle;

		[SerializeField]
		private UnityEvent OnCancelEvent;

		private bool initialized;

		private bool isMenuEnabled;

		private GameObject lastSelection;

		private Action onCompleteAction;

		private int m_CurrentEntry;

		private int m_CurrentPlayerID;

		public ModalManager Modal => null;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnControllerDisconnected(in InputDevice device, int userIndex)
		{
		}

		private void OnControllerConnected(in InputDevice device, int userIndex)
		{
		}

		public void BeginInteractiveRebind(int playerID, InputUser user, InputAction action, ActionToStringEntry entry, int bindingIndex, int compositeIndex, bool allCompositeParts, OnRebindComplete completedDelegate, OnRebindCancelled cancelledDelegate)
		{
		}

		public void PerformInteractiveRebind(int playerID, InputUser user, InputAction action, ActionToStringEntry entry, int bindingIndex, int compositeIndex, bool allCompositeParts, OnRebindComplete completedDelegate, OnRebindCancelled cancelledDelegate, string compositeIgnore = "")
		{
		}

		private void CorrectOtherAssignedBindings(int playerID, InputAction assignedAction, int bindingIndex, int compositeIndex)
		{
		}

		public void OpenModalWithMessage(string device, string action)
		{
		}

		public void CloseModal()
		{
		}

		public void ShowUI(bool hidebuttons)
		{
		}

		public void HideUI()
		{
		}

		public void CloseMenu()
		{
		}

		public void SetSelectedPlayer(int playerId)
		{
		}

		public void SetSelectedPlayer(int playerId, Action callback = null)
		{
		}

		public void OnCancel()
		{
		}

		private void OnRemappingFinished()
		{
		}

		public void OnMenuEntered()
		{
		}

		public void SetMenuState(bool state)
		{
		}

		private void SetUISelectionOnMenuStateChange(bool state)
		{
		}

		private void BeginInputAssignment(int playerID)
		{
		}

		private void RebindEntry(in ActionToStringEntry entry, int playerID)
		{
		}

		public void OnRebindCompleteCallback()
		{
		}

		public void OnRebindCancelledCallback()
		{
		}
	}
}
