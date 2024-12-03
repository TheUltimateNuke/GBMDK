using GB.Game.Critters;

namespace GB.FSM.Bird
{
	public class CarryActorState : BirdFSMState
	{
		private BirdActor actorRef;

		private float currentAttackForce;

		private float baseAttackForce;

		private float maxAttackVelocity;

		public CarryActorState(BirdFSM stateMachine)
			: base(null, null, default(BirdFSM.BirdStateID))
		{
		}

		public override void EnterServer()
		{
		}

		public override void FixedUpdateLogicServer()
		{
		}

		public override void ExitServer()
		{
		}

		public override void FixedUpdateLogicClient()
		{
		}
	}
}
