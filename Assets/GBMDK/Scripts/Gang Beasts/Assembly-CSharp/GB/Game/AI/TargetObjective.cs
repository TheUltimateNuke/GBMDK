using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using UnityEngine;

namespace GB.Game.AI
{
	public class TargetObjective : MonoBehaviour
	{
		private delegate bool GoalCondition();

		public enum ObjectiveGoal
		{
			MoveTo = 0,
			Wait = 1
		}

		[CompilerGenerated]
		private sealed class _003CObjectiveUpdateRoutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TargetObjective _003C_003E4__this;

			public Action<Actor, TargetObjective> OnComplete;

			private bool _003ChasCompletedGoal_003E5__2;

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
			public _003CObjectiveUpdateRoutine_003Ed__22(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CWaitObjective_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TargetObjective _003C_003E4__this;

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
			public _003CWaitObjective_003Ed__25(int _003C_003E1__state)
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

		private Actor _actorRef;

		private Transform target;

		private float waitDuration;

		private Coroutine objectiveUpdate;

		private Coroutine waitObjectiveCoroutine;

		private bool waitObjectiveComplete;

		private GoalCondition ConditionPredicate;

		private ObjectiveGoal _objective;

		public bool ActiveRunning => false;

		public bool WaitObjectiveComplete
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float WaitDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool Targeted(Actor actor)
		{
			return false;
		}

		private void OnDisable()
		{
		}

		public void Initialize(Actor actor)
		{
		}

		public void SetObjective(Transform t, ObjectiveGoal objective, Action<Actor, TargetObjective> OnComplete)
		{
		}

		[IteratorStateMachine(typeof(_003CObjectiveUpdateRoutine_003Ed__22))]
		private IEnumerator ObjectiveUpdateRoutine(Action<Actor, TargetObjective> OnComplete)
		{
			return null;
		}

		private void InitializeGoalCondition()
		{
		}

		private void StartWaitObjective()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitObjective_003Ed__25))]
		private IEnumerator WaitObjective()
		{
			return null;
		}

		private void StopCurrentObjective()
		{
		}

		private void OnDestroy()
		{
		}

		private void TargetObjectiveDebug()
		{
		}
	}
}
