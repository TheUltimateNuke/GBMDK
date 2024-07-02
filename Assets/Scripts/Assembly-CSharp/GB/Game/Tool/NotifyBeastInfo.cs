using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using GB.Game.Tool.ActorEvents;
using UnityEngine;

namespace GB.Game.Tool
{
	public class NotifyBeastInfo : MonoBehaviour, IActorOnTriggerEvent
	{
		[CompilerGenerated]
		private sealed class _003CShowLogic_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NotifyBeastInfo _003C_003E4__this;

			public Actor actor;

			private float _003Ctimer_003E5__2;

			private int _003ClastTime_003E5__3;

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
			public _003CShowLogic_003Ed__7(int _003C_003E1__state)
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

		[SerializeField]
		private bool _notifyAI;

		[SerializeField]
		private bool _showNamebars;

		[SerializeField]
		private bool _vibController;

		[SerializeField]
		private float _forTime;

		private Dictionary<Actor, Coroutine> _activeInformers;

		private void OnDisabled()
		{
		}

		public void Event(Actor actor)
		{
		}

		[IteratorStateMachine(typeof(_003CShowLogic_003Ed__7))]
		private IEnumerator ShowLogic(Actor actor)
		{
			return null;
		}
	}
}
