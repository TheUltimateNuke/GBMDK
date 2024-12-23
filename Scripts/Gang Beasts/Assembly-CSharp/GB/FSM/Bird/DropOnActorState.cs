using GB.Game.Critters;

namespace GB.FSM.Bird
{
	public class DropOnActorState : BirdFSMState
	{
		private BirdActor actorRef;

		private float currentAttackForce;

		private float baseAttackForce;

		private float upForceMod;

		public DropOnActorState(BirdFSM stateMachine)
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
