using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using UnityEngine;

namespace GB.Game.AI
{
	public class AIMoveObjective : AIBehaviourBase
	{
		[CompilerGenerated]
		private sealed class _003CWaitForAIToReachNode_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Actor actor;

			public AIMoveObjective _003C_003E4__this;

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
			public _003CWaitForAIToReachNode_003Ed__9(int _003C_003E1__state)
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
		private List<Transform> _aiMoveNodes;

		[SerializeField]
		private float distanceToNodeThreshold;

		[SerializeField]
		private bool _refreshCamera;

		private Transform _targetNode;

		private Coroutine _aiMoveCoroutine;

		public override void ExecuteBehaviour(Actor actor)
		{
		}

		private void StartAIMoveToPosition(Actor newActor)
		{
		}

		private void StartMoveCoroutine(Actor actor)
		{
		}

		public Transform GetRandomAIMoveNodeTransform()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWaitForAIToReachNode_003Ed__9))]
		private IEnumerator WaitForAIToReachNode(Actor actor)
		{
			return null;
		}

		public void ReturnControl(Actor actor, TargetObjective objective)
		{
		}
	}
}
