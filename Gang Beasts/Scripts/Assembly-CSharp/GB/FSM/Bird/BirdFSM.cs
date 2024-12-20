using System.Runtime.CompilerServices;
using GB.Game.Critters;
using UnityEngine;

namespace GB.FSM.Bird
{
	[RequireComponent(typeof(BirdActor))]
	public class BirdFSM : StateMachine
	{
		public delegate void StateChange(int stateID);

		public enum BirdStateID
		{
			Sleeping = 0,
			Perch = 1,
			Idle = 2,
			Wandering = 3,
			AttackEnvironment = 4,
			AttackActor = 5,
			DropOnActor = 6,
			CarryEnvironemnt = 7,
			CarryActor = 8,
			Unconscious = 9
		}

		private BirdStateID currentStateId;

		[HideInInspector]
		public BirdActor birdActor;

		[HideInInspector]
		public float maxTimeInState;

		[HideInInspector]
		public float currTimeInState;

		[HideInInspector]
		public SleepState sleepState;

		[HideInInspector]
		public IdleState idleState;

		[HideInInspector]
		public PerchState perchState;

		[HideInInspector]
		public WanderingState wanderingState;

		[HideInInspector]
		public AttackingEnvironmentState attackingEnvironmentState;

		[HideInInspector]
		public AttackingActorState attackingActorState;

		[HideInInspector]
		public CarryEnvironmentState carryEnvironmentState;

		[HideInInspector]
		public CarryActorState carryActorState;

		[HideInInspector]
		public DropOnActorState dropOnActorState;

		[HideInInspector]
		public UnconciousState unconciousState;

		public event StateChange onStateChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void SetStateID(BirdStateID newID)
		{
		}

		private void Awake()
		{
		}

		public override void ChangeState(BaseState newState)
		{
		}

		protected override BaseState GetInitialState()
		{
			return null;
		}

		public BirdStateID GetCurrentStateID()
		{
			return default(BirdStateID);
		}

		public void SetStateByID(int id)
		{
		}

		public void SetStateByID(BirdStateID id)
		{
		}
	}
}
