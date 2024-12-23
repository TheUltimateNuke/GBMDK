using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB.Platform.UI.Lobby
{
	public class LobbyJumper : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CRunCheckingLook_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LobbyJumper _003C_003E4__this;

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
			public _003CRunCheckingLook_003Ed__9(int _003C_003E1__state)
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

		public GameObject LobbyMenu;

		public GameObject QuickfindMenu;

		public GameObject[] Menus;

		private void Awake()
		{
		}

		private void PlatformEvents_OnEntitlementChangedEvent(bool effect)
		{
		}

		private void OnDestroy()
		{
		}

		private void OnLobbyJoinedEvent()
		{
		}

		private void OnEnable()
		{
		}

		public void CheckLobby()
		{
		}

		[IteratorStateMachine(typeof(_003CRunCheckingLook_003Ed__9))]
		private IEnumerator RunCheckingLook()
		{
			return null;
		}

		public void ManualQuickfindReconnJump()
		{
		}
	}
}
