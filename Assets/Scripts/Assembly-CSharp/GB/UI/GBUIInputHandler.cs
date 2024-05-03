using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GB.UI
{
	public class GBUIInputHandler : PointerInputModule
	{
		public const int k_MouseKeyboardPlayerIndex = 0;

		public static bool OverrideUIInput;

		private int[] _defaultInputs;

		[SerializeField]
		private int[] _allowInputPlayers;

		private int _lastActiveUIPlayer;

		private bool moveOncePerAxisPress;

		private float movementRepeatDelayX;

		private float movementRepeatDelayY;

		private float thumbstickDeadzone;

		private float lastMovePropagateTimeX;

		private float lastMovePropagateTimeY;

		public bool isMouseControlEnabled;

		private Vector2 previousMousePos;

		private Vector2 currentMousePos;

		private bool _hasLostFocus;

		public int[] AllowedInputPlayerID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int LastActiveUIPlayer
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static event Action<GBUIInputHandler, BaseEventData> OnCancel
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<GBUIInputHandler, BaseEventData> OnSubmit
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnAllowedInputChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<int> OnLastInputChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		protected override void Awake()
		{
		}

		public static void ClearButtons()
		{
		}

		public override bool IsModuleSupported()
		{
			return false;
		}

		public override void Process()
		{
		}

		private void ProcessUnityMouse()
		{
		}

		private new PointerEventData GetMousePointerEventData()
		{
			return null;
		}

		private void ProcessMousePress(bool wasPressedThisFrame, bool wasReleasedThisFrame, in PointerEventData pointerData)
		{
		}

		private Vector2 GetNonMouseMove()
		{
			return default(Vector2);
		}

		private float CheckMovePropagation(float value, ref float timer, float waitTime)
		{
			return 0f;
		}

		private bool ProcessNonMouseMoveEvent()
		{
			return false;
		}

		private void ProcessNonMouseSubmitEvent()
		{
		}

		private void TriggerCancelEvent(BaseEventData data)
		{
		}

		private void TriggerSubmitEvent(BaseEventData data)
		{
		}

		public void ForceClick()
		{
		}

		public void ForceCancel()
		{
		}

		public void ForceDeselect()
		{
		}

		public void ForceSelect(GameObject target)
		{
		}

		public override void ActivateModule()
		{
		}

		public override void DeactivateModule()
		{
		}

		public override void UpdateModule()
		{
		}

		protected bool UpdateSelectedObject()
		{
			return false;
		}

		private Vector2 GetMousePosition()
		{
			return default(Vector2);
		}

		public void ResetActivePlayersToDefault()
		{
		}

		public bool PlayerHasUIControl(int playerID)
		{
			return false;
		}
	}
}
