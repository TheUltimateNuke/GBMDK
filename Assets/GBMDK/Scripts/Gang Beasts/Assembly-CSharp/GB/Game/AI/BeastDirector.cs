using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using GB.Game.Tool.ActorEvents;
using UnityEngine;

namespace GB.Game.AI
{
	public class BeastDirector : MonoBehaviour, IActorOnTriggerEvent
	{
		[CompilerGenerated]
		private sealed class _003CStartAIObjectives_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BeastDirector _003C_003E4__this;

			public Actor actor;

			private int _003Ci_003E5__2;

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
			public _003CStartAIObjectives_003Ed__8(int _003C_003E1__state)
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
		private bool _doOnSpawn;

		[SerializeField]
		private OnActorEventBase _onCompleteEventTrigger;

		[SerializeField]
		[Tooltip("AI behaviours added will be executed in the order provided")]
		private List<AIBehaviourBase> _aiObjectivesQueue;

		private Coroutine _aiObjectivesCoroutine;

		private bool currentobjectiveComplete;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void StartBeastDirecting(Actor newActor)
		{
		}

		[IteratorStateMachine(typeof(_003CStartAIObjectives_003Ed__8))]
		private IEnumerator StartAIObjectives(Actor actor)
		{
			return null;
		}

		private void CheckObjectiveComplete(Actor actor)
		{
		}

		public void Event(Actor actor)
		{
		}
	}
}
