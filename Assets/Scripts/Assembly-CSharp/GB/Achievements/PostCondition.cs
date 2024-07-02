using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using GB.Utils;
using UnityEngine;

namespace GB.Achievements
{
	[Serializable]
	public class PostCondition
	{
		[Serializable]
		public delegate bool Condition(Actor beastRef);

		[Serializable]
		public delegate void Response(bool status, Actor beastRef);

		[CompilerGenerated]
		private sealed class _003CCheckContinualCondition_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PostCondition _003C_003E4__this;

			public Actor beastRef;

			private float _003CstartTimer_003E5__2;

			private bool _003CshouldLoop_003E5__3;

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
			public _003CCheckContinualCondition_003Ed__21(int _003C_003E1__state)
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

		public Condition ConditionPredicate;

		public string ConditionHumanName;

		[SerializeField]
		public ConditionArchtypes ConditionType;

		public Actor.ActorState targetState;

		public bool targetStateValue;

		public GameObject targetObject;

		public Collider targetArea;

		public bool targetShouldBeIn;

		public bool targetStartsIn;

		private bool objectCurrentlyPresent;

		private TriggerDetection heldTrigRef;

		[Tooltip("How long this condition should check for")]
		[SerializeField]
		public float Timer;

		[Tooltip("A Permanence condition must always be met to pass - \r\n a non-Permanence condition must only be met at the end of the timeout.")]
		[SerializeField]
		public bool Permanence;

		private Response onComplete;

		public PostCondition(string friendlyName, ConditionArchtypes type, float timer, bool permanence = false)
		{
		}

		public void Initialise()
		{
		}

		public void StartCondition(Response response, Actor beastRef)
		{
		}

		private void RecreateDelegate(Actor beastRef)
		{
		}

		private void CheckCondition(Actor beastRef)
		{
		}

		[IteratorStateMachine(typeof(_003CCheckContinualCondition_003Ed__21))]
		private IEnumerator CheckContinualCondition(Actor beastRef)
		{
			return null;
		}
	}
}
