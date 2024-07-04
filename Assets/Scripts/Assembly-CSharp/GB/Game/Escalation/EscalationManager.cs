using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using UnityEngine;

namespace GB.Game.Escalation
{
	public class EscalationManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CEscalationRoutine_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EscalationManager _003C_003E4__this;

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
			public _003CEscalationRoutine_003Ed__31(int _003C_003E1__state)
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

		private List<EscalationBase> allEscalations;

		private List<EscalationBase> minorEscalations;

		private List<EscalationBase> majorEscalations;

		private List<EscalationBase> finalEscalations;

		private bool _allowMinors;

		private bool _allowMajors;

		private bool _allowFinals;

		private bool _canEscalateOnPlayerDeath;

		private float _escalationDuration;

		private float _escalationTimeRemaining;

		private Coroutine escalationRoutine;

		private Dictionary<string, EscalationData> escalationSceneData;

		private GameManagerNew _gm;

		public Action OnSetupComplete;

		public bool CanEscalate => false;

		public float EscalationDuration => 0f;

		public float EscalationTimeRemaining => 0f;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnNetRoundOrganiserStarted()
		{
		}

		private void NetRoundOrganiser_OnGameSetup()
		{
		}

		private void NetRoundOrganiser_OnGameStart()
		{
		}

		private void OnActorStateChanged(Actor actor, int connectionId, Actor.ActorState state)
		{
		}

		public void Setup(string sceneName)
		{
		}

		public bool RegisterEscalation(EscalationBase escalation)
		{
			return false;
		}

		private bool IsAllowedEscalation(EscalationBase escalation)
		{
			return false;
		}

		private void StartEscalationTimer()
		{
		}

		private void StopEscalationTimer()
		{
		}

		[IteratorStateMachine(typeof(_003CEscalationRoutine_003Ed__31))]
		private IEnumerator EscalationRoutine()
		{
			return null;
		}
	}
}
