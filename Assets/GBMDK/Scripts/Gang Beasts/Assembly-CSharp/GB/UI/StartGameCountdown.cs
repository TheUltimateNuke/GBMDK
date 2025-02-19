using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Platform.Lobby;
using GB.UI.Beasts;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace GB.UI
{
	public class StartGameCountdown : MonoBehaviour
	{
		[Serializable]
		public class StringEvent : UnityEvent
		{
		}

		[CompilerGenerated]
		private sealed class _003CCountdown_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StartGameCountdown _003C_003E4__this;

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
			public _003CCountdown_003Ed__24(int _003C_003E1__state)
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

		public StringEvent Complete;

		[SerializeField]
		private UnityEvent OnTimerStart;

		[SerializeField]
		private UnityEvent OnTimerEnded;

		[SerializeField]
		private bool _resetOnStart;

		private float _countdownTimer;

		private float _currentCountdown;

		private Coroutine _countdownCoroutine;

		public bool CountdownActive => false;

		public event Action<float> OnTimerChanged
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

		public event Action<bool> OnTimerActive
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void TeamChanged(LocalPlayerInfomationCache player, int old)
		{
		}

		private void PlatformEvents_OnMainUserStateEvent(bool effect)
		{
		}

		private void OnControllerDisconnected(in InputDevice device, int userIndex)
		{
		}

		private void StateChanged(LocalPlayerInfomationCache player, BeastUtils.PlayerState old)
		{
		}

		private void SettingChanged()
		{
		}

		public void StartTimer()
		{
		}

		[IteratorStateMachine(typeof(_003CCountdown_003Ed__24))]
		private IEnumerator Countdown()
		{
			return null;
		}

		public void TerminateTimer()
		{
		}

		public void StopTimer()
		{
		}
	}
}
