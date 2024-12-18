using GB.Game.Critters;

namespace GB.FSM.Bird
{
	public class AttackingActorState : BirdFSMState
	{
		private BirdActor actorRef;

		private float maxAttackVelocity;

		private float attackForce;

		private float stuckResetTimer;

		private const float REFRESH_THRESHOLD = 3f;

		public AttackingActorState(BirdFSM stateMachine)
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
