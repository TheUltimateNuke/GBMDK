using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Setup;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Users;

namespace GB.Input
{
	public class UnityInputSystemManager : MonoSingleton<UnityInputSystemManager>, IPostAsyncLoadingActivator
	{
		[Serializable]
		public struct Layout
		{
			public List<string> LayoutPaths;
		}

		[Serializable]
		public struct LayoutMap
		{
			public List<string> ActionsToRemap;
		}

		public delegate void OnDevicesUpdated();

		public delegate void OnNewUser(in InputUser newUser);

		public delegate void OnControllerDisconnected(in InputDevice disconnectedDevice, int userIndex);

		public delegate void OnControllerReconnected(in InputDevice reconnectedDevice, int userIndex);

		private struct VibrationState
		{
			public bool Vibrating;

			public float TimeRemaining;
		}

		[CompilerGenerated]
		private sealed class _003CPairInitialUsers_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UnityInputSystemManager _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CPairInitialUsers_003Ed__57(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		public LayoutMap LayoutMapDefinition;

		public List<Layout> Layouts;

		public OnDevicesUpdated OnDevicesUpdatedDelegate;

		public OnNewUser OnNewUserDelegate;

		public OnControllerDisconnected OnControllerDisconnectedDelegate;

		public OnControllerReconnected OnControllerReconnectedDelegate;

		public IControllerAssigner DeviceAssigner;

		private List<InputUser> m_UserList;

		private List<VibrationState> m_VibrationStatesForUsers;

		private bool m_VibrationEnabled;

		private bool m_mainThreadAnyInput;

		private bool m_updateThreadAnyInput;

		private bool m_mainThreadUpdate;

		private bool m_anyInputJustRead;

		private InputDevice m_LastDetectedInputDevice;

		private int m_MapLayoutIndex;

		private bool m_HasPairedInitialUsers;

		private bool m_PairingInitialUsers;

		private bool _HasLostFocus;

		public bool AnyInputDetected => false;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public int GetNumUsers()
		{
			return 0;
		}

		public InputUser GetUser(int userIndex)
		{
			return default(InputUser);
		}

		public int GetLastDetectedInputUserIndex()
		{
			return 0;
		}

		public InputDevice GetLastDetectedInputDevice()
		{
			return null;
		}

		public bool TryGetUser(int userIndex, out InputUser user)
		{
			user = default(InputUser);
			return false;
		}

		public void ResetUser(int userIndex)
		{
		}

		public int GetUserDeviceTypeIndex(in InputUser deviceUser, string layout)
		{
			return 0;
		}

		public InputUser FindUserWithDeviceTypeIndex(string layout, int deviceTypeIndex)
		{
			return default(InputUser);
		}

		public void SetVibrationEnabled(bool enabled, bool feedback = false)
		{
		}

		public bool GetVibrationEnabled()
		{
			return false;
		}

		public void SetVibration(in InputUser user, float lowFrequency, float highFrequency, float duration)
		{
		}

		public void StopVibration(in InputUser user)
		{
		}

		private void StopVibration(int index)
		{
		}

		private int GetUserIndex(in InputUser user)
		{
			return 0;
		}

		private int GetUserIndexWithSpecificDevice(in InputDevice device)
		{
			return 0;
		}

		public bool AnyInputDetectedFromUser(InputUser user)
		{
			return false;
		}

		private void OnDeviceChange(InputDevice device, InputDeviceChange change)
		{
		}

		private void OnEvent(InputEventPtr eventPtr, InputDevice device)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public int FindUserWithDevice()
		{
			return 0;
		}

		public int FindUserWithDevice(InputDevice device)
		{
			return 0;
		}

		public int FindUserWithDevice(Type type)
		{
			return 0;
		}

		public int FirstInputlessUser(bool allowDisconnected)
		{
			return 0;
		}

		public void AddDevice(InputDevice device, int index, bool clearOld)
		{
		}

		public void RemoveDevice(InputDevice device)
		{
		}

		public void BeginPostAsyncLoadingActivation()
		{
		}

		public bool HasFinishedPostAsyncLoadingActivation()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CPairInitialUsers_003Ed__57))]
		private IEnumerator PairInitialUsers()
		{
			return null;
		}

		private void Update()
		{
		}

		public void SetMapLayout(int layout)
		{
		}

		public int GetMapLayout()
		{
			return 0;
		}

		public bool MoveDevices(int from, int target)
		{
			return false;
		}
	}
}
