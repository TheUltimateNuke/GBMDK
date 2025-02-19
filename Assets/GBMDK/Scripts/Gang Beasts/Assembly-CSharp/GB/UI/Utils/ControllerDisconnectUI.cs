using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GB.UI.Utils
{
	public class ControllerDisconnectUI : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003COnDismissDisconnectWarningCoroutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ControllerDisconnectUI _003C_003E4__this;

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

			object IEnumerator<object>.Current => throw new NotImplementedException();

			object IEnumerator.Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003COnDismissDisconnectWarningCoroutine_003Ed__14(int _003C_003E1__state)
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
				return MoveNext();
			}

			void IEnumerator.Reset()
			{
				throw new NotImplementedException();
			}

			void IDisposable.Dispose()
			{
				throw new NotImplementedException();
			}
		}

		private string CONTROLLER_DISCONNECT_KEY;

		private int _lostController;

		private bool _isShowingDisconnect;

		private List<int> _userCache;

		private List<int> _freeInputs;

		public bool IsShowing => false;

		public void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnControllerDisconnected(in InputDevice device, int userIndex)
		{
		}

		private bool ShowDisconnectMessage()
		{
			return false;
		}

		private void ControllerSetupSwitcher()
		{
		}

		private void OnControllerConnected(in InputDevice device, int userIndex)
		{
		}

		private void OnDismissDisconnectWarning()
		{
		}

		[IteratorStateMachine(typeof(_003COnDismissDisconnectWarningCoroutine_003Ed__14))]
		private IEnumerator OnDismissDisconnectWarningCoroutine()
		{
			return null;
		}

		private void CleanLostPlayers()
		{
		}

		private void ReassignControllerLost()
		{
		}

		private void RegisterInputEvents()
		{
		}
	}
}
