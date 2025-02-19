using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace GB.Game.Tool
{
	public class TimedEvent : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CTimerLogic_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimedEvent _003C_003E4__this;

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
			public _003CTimerLogic_003Ed__11(int _003C_003E1__state)
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

		[SerializeField]
		private float _waitTime;

		[SerializeField]
		private UnityEvent _onStart;

		[SerializeField]
		private UnityEvent _onComplete;

		[SerializeField]
		private bool _completeIfStopped;

		[SerializeField]
		private bool _gameTime;

		private Coroutine _logic;

		public bool Running => false;

		private void OnDisable()
		{
		}

		public void StartTimer(bool restart)
		{
		}

		public void StopTimer()
		{
		}

		[IteratorStateMachine(typeof(_003CTimerLogic_003Ed__11))]
		private IEnumerator TimerLogic()
		{
			return null;
		}
	}
}
