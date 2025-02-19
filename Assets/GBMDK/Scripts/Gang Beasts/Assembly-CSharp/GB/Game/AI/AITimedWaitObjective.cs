using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using UnityEngine;

namespace GB.Game.AI
{
	public class AITimedWaitObjective : AIBehaviourBase
	{
		[CompilerGenerated]
		private sealed class _003CWaitObjective_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AITimedWaitObjective _003C_003E4__this;

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
			public _003CWaitObjective_003Ed__7(int _003C_003E1__state)
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
		private float _waitDuration;

		private Coroutine _waitCoroutine;

		private WaitForSeconds _waitSeconds;

		protected override void Awake()
		{
		}

		public override void ExecuteBehaviour(Actor actor)
		{
		}

		private void StartWaitObjective(Actor newActor)
		{
		}

		private void StartWaitCoroutine()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitObjective_003Ed__7))]
		private IEnumerator WaitObjective()
		{
			return null;
		}

		private void OnObjectiveComplete(Actor actor, TargetObjective objective)
		{
		}
	}
}
