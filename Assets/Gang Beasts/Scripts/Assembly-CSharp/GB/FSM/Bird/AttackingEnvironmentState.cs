using GB.Game.Critters;

namespace GB.FSM.Bird
{
	public class AttackingEnvironmentState : BirdFSMState
	{
		private BirdActor actorRef;

		private float maxAttackVelocity;

		private float attackForce;

		public AttackingEnvironmentState(BirdFSM stateMachine)
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
