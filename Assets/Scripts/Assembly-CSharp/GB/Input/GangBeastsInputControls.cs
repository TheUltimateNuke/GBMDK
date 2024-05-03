using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace GB.Input
{
	public class GangBeastsInputControls : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
	{
		public struct PlayerActions
		{
			private GangBeastsInputControls m_Wrapper;

			public InputAction Jump => null;

			public InputAction Kick => null;

			public InputAction Duck => null;

			public InputAction Lift => null;

			public InputAction GrabLeft => null;

			public InputAction GrabRight => null;

			public InputAction Pause => null;

			public InputAction CameraNext => null;

			public InputAction CameraPrev => null;

			public InputAction CycleTrackingType => null;

			public InputAction PrevSpectator => null;

			public InputAction NextSpectator => null;

			public InputAction MoveHorizontal => null;

			public InputAction MoveVertical => null;

			public bool enabled => false;

			public PlayerActions(GangBeastsInputControls wrapper):this()
			{
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(PlayerActions set)
			{
				return null;
			}

			public void SetCallbacks(IPlayerActions instance)
			{
			}
		}

		public struct UIActions
		{
			private GangBeastsInputControls m_Wrapper;

			public InputAction Navigate => null;

			public InputAction Submit => null;

			public InputAction Cancel => null;

			public InputAction Point => null;

			public InputAction Click => null;

			public InputAction ScrollWheel => null;

			public InputAction MiddleClick => null;

			public InputAction RightClick => null;

			public InputAction TrackedDevicePosition => null;

			public InputAction TrackedDeviceOrientation => null;

			public InputAction ColourChangeUp => null;

			public InputAction ColourChangeDown => null;

			public InputAction RotateBeast => null;

			public InputAction Costume_Reset => null;

			public InputAction Costume_Tint => null;

			public InputAction Main_User_Change => null;

			public InputAction ShowPlayerNames => null;

			public InputAction SystemButton => null;

			public InputAction SystemMessengerGamepadA => null;

			public InputAction SystemMessengerGamepadB => null;

			public InputAction SystemMessengerKeyboardA => null;

			public InputAction SystemMessengerKeyboardB => null;

			public InputAction SystemMessengerSwitchA => null;

			public InputAction SystemMessengerSwitchB => null;

			public InputAction DebugGUIColor => null;

			public InputAction Switch_ChangeControllers => null;

			public InputAction Menu_Lobby_Kick => null;

			public InputAction Toggle_Public_Private => null;

			public InputAction Invite_Friend => null;

			public InputAction Platform_ShowInfo => null;

			public InputAction PS4_SafeArea => null;

			public InputAction SwitchCostume_Reset => null;

			public InputAction SwitchCostume_Tint => null;

			public bool enabled => false;

			public UIActions(GangBeastsInputControls wrapper):this()
			{
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(UIActions set)
			{
				return null;
			}

			public void SetCallbacks(IUIActions instance)
			{
			}
		}

		public interface IPlayerActions
		{
			void OnJump(InputAction.CallbackContext context);

			void OnKick(InputAction.CallbackContext context);

			void OnDuck(InputAction.CallbackContext context);

			void OnLift(InputAction.CallbackContext context);

			void OnGrabLeft(InputAction.CallbackContext context);

			void OnGrabRight(InputAction.CallbackContext context);

			void OnPause(InputAction.CallbackContext context);

			void OnCameraNext(InputAction.CallbackContext context);

			void OnCameraPrev(InputAction.CallbackContext context);

			void OnCycleTrackingType(InputAction.CallbackContext context);

			void OnPrevSpectator(InputAction.CallbackContext context);

			void OnNextSpectator(InputAction.CallbackContext context);

			void OnMoveHorizontal(InputAction.CallbackContext context);

			void OnMoveVertical(InputAction.CallbackContext context);
		}

		public interface IUIActions
		{
			void OnNavigate(InputAction.CallbackContext context);

			void OnSubmit(InputAction.CallbackContext context);

			void OnCancel(InputAction.CallbackContext context);

			void OnPoint(InputAction.CallbackContext context);

			void OnClick(InputAction.CallbackContext context);

			void OnScrollWheel(InputAction.CallbackContext context);

			void OnMiddleClick(InputAction.CallbackContext context);

			void OnRightClick(InputAction.CallbackContext context);

			void OnTrackedDevicePosition(InputAction.CallbackContext context);

			void OnTrackedDeviceOrientation(InputAction.CallbackContext context);

			void OnColourChangeUp(InputAction.CallbackContext context);

			void OnColourChangeDown(InputAction.CallbackContext context);

			void OnRotateBeast(InputAction.CallbackContext context);

			void OnCostume_Reset(InputAction.CallbackContext context);

			void OnCostume_Tint(InputAction.CallbackContext context);

			void OnMain_User_Change(InputAction.CallbackContext context);

			void OnShowPlayerNames(InputAction.CallbackContext context);

			void OnSystemButton(InputAction.CallbackContext context);

			void OnSystemMessengerGamepadA(InputAction.CallbackContext context);

			void OnSystemMessengerGamepadB(InputAction.CallbackContext context);

			void OnSystemMessengerKeyboardA(InputAction.CallbackContext context);

			void OnSystemMessengerKeyboardB(InputAction.CallbackContext context);

			void OnSystemMessengerSwitchA(InputAction.CallbackContext context);

			void OnSystemMessengerSwitchB(InputAction.CallbackContext context);

			void OnDebugGUIColor(InputAction.CallbackContext context);

			void OnSwitch_ChangeControllers(InputAction.CallbackContext context);

			void OnMenu_Lobby_Kick(InputAction.CallbackContext context);

			void OnToggle_Public_Private(InputAction.CallbackContext context);

			void OnInvite_Friend(InputAction.CallbackContext context);

			void OnPlatform_ShowInfo(InputAction.CallbackContext context);

			void OnPS4_SafeArea(InputAction.CallbackContext context);

			void OnSwitchCostume_Reset(InputAction.CallbackContext context);

			void OnSwitchCostume_Tint(InputAction.CallbackContext context);
		}

		private readonly InputActionMap m_Player;

		private IPlayerActions m_PlayerActionsCallbackInterface;

		private readonly InputAction m_Player_Jump;

		private readonly InputAction m_Player_Kick;

		private readonly InputAction m_Player_Duck;

		private readonly InputAction m_Player_Lift;

		private readonly InputAction m_Player_GrabLeft;

		private readonly InputAction m_Player_GrabRight;

		private readonly InputAction m_Player_Pause;

		private readonly InputAction m_Player_CameraNext;

		private readonly InputAction m_Player_CameraPrev;

		private readonly InputAction m_Player_CycleTrackingType;

		private readonly InputAction m_Player_PrevSpectator;

		private readonly InputAction m_Player_NextSpectator;

		private readonly InputAction m_Player_MoveHorizontal;

		private readonly InputAction m_Player_MoveVertical;

		private readonly InputActionMap m_UI;

		private IUIActions m_UIActionsCallbackInterface;

		private readonly InputAction m_UI_Navigate;

		private readonly InputAction m_UI_Submit;

		private readonly InputAction m_UI_Cancel;

		private readonly InputAction m_UI_Point;

		private readonly InputAction m_UI_Click;

		private readonly InputAction m_UI_ScrollWheel;

		private readonly InputAction m_UI_MiddleClick;

		private readonly InputAction m_UI_RightClick;

		private readonly InputAction m_UI_TrackedDevicePosition;

		private readonly InputAction m_UI_TrackedDeviceOrientation;

		private readonly InputAction m_UI_ColourChangeUp;

		private readonly InputAction m_UI_ColourChangeDown;

		private readonly InputAction m_UI_RotateBeast;

		private readonly InputAction m_UI_Costume_Reset;

		private readonly InputAction m_UI_Costume_Tint;

		private readonly InputAction m_UI_Main_User_Change;

		private readonly InputAction m_UI_ShowPlayerNames;

		private readonly InputAction m_UI_SystemButton;

		private readonly InputAction m_UI_SystemMessengerGamepadA;

		private readonly InputAction m_UI_SystemMessengerGamepadB;

		private readonly InputAction m_UI_SystemMessengerKeyboardA;

		private readonly InputAction m_UI_SystemMessengerKeyboardB;

		private readonly InputAction m_UI_SystemMessengerSwitchA;

		private readonly InputAction m_UI_SystemMessengerSwitchB;

		private readonly InputAction m_UI_DebugGUIColor;

		private readonly InputAction m_UI_Switch_ChangeControllers;

		private readonly InputAction m_UI_Menu_Lobby_Kick;

		private readonly InputAction m_UI_Toggle_Public_Private;

		private readonly InputAction m_UI_Invite_Friend;

		private readonly InputAction m_UI_Platform_ShowInfo;

		private readonly InputAction m_UI_PS4_SafeArea;

		private readonly InputAction m_UI_SwitchCostume_Reset;

		private readonly InputAction m_UI_SwitchCostume_Tint;

		private int m_GamepadSchemeIndex;

		private int m_KeyboardSchemeIndex;

		private int m_MouseSchemeIndex;

		public InputActionAsset asset { get; }

		public InputBinding? bindingMask
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ReadOnlyArray<InputDevice>? devices
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ReadOnlyArray<InputControlScheme> controlSchemes => default(ReadOnlyArray<InputControlScheme>);

		public IEnumerable<InputBinding> bindings => null;

		public PlayerActions Player => default(PlayerActions);

		public UIActions UI => default(UIActions);

		public InputControlScheme GamepadScheme => default(InputControlScheme);

		public InputControlScheme KeyboardScheme => default(InputControlScheme);

		public InputControlScheme MouseScheme => default(InputControlScheme);

		public void Dispose()
		{
		}

		public bool Contains(InputAction action)
		{
			return false;
		}

		public IEnumerator<InputAction> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
		{
			return null;
		}

		public int FindBinding(InputBinding bindingMask, out InputAction action)
		{
			action = null;
			return 0;
		}

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
