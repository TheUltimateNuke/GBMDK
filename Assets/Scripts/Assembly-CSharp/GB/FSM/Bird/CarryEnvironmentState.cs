using GB.Game.Critters;

namespace GB.FSM.Bird
{
	public class CarryEnvironmentState : BirdFSMState
	{
		private BirdActor actorRef;

		private float currentAttackForce;

		private float baseAttackForce;

		private float maxAttackVelocity;

		public CarryEnvironmentState(BirdFSM stateMachine)
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
