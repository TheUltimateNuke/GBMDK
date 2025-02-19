using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using UnityEngine;

namespace GB.Game.Tool.ActorEvents
{
	public class OnTriggerTimedEvent : OnActorEventBase, IActorOnTriggerEvent
	{
		[CompilerGenerated]
		private sealed class _003CTimerUpdate_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OnTriggerTimedEvent _003C_003E4__this;

			public Actor actor;

			private float _003Ctimer_003E5__2;

			private int _003CnextlastShow_003E5__3;

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
			public _003CTimerUpdate_003Ed__4(int _003C_003E1__state)
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
		private float _timer;

		[SerializeField]
		private float _showIfUnder;

		private Dictionary<Actor, Coroutine> _activeBeasts;

		public void StartTimer(Actor actor)
		{
		}

		[IteratorStateMachine(typeof(_003CTimerUpdate_003Ed__4))]
		private IEnumerator TimerUpdate(Actor actor)
		{
			return null;
		}

		public void EndTimer(Actor actor, bool trigger)
		{
		}

		public void Event(Actor actor)
		{
		}
	}
}
