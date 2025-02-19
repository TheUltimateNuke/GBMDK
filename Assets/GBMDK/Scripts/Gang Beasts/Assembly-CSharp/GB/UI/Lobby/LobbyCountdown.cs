using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB.UI.Lobby
{
	public class LobbyCountdown : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCountdown_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float time;

			public LobbyCountdown _003C_003E4__this;

			public Action onComplete;

			private int _003ClastTime_003E5__2;

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
			public _003CCountdown_003Ed__5(int _003C_003E1__state)
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

		public bool playCountdownAudio;

		private Coroutine _countdown;

		public bool CountdownActive => false;

		public void StartCountdown(float countdown, Action onComplete)
		{
		}

		[IteratorStateMachine(typeof(_003CCountdown_003Ed__5))]
		private IEnumerator Countdown(float time, Action onComplete)
		{
			return null;
		}

		public void StopCountdown()
		{
		}

		private void SendTimer(int value)
		{
		}

		private void HideTimer()
		{
		}
	}
}
