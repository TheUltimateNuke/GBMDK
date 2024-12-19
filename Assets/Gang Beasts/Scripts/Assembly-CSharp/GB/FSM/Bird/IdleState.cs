using GB.Game.Critters;

namespace GB.FSM.Bird
{
	public class IdleState : BirdFSMState
	{
		private BirdActor actorRef;

		public IdleState(BirdFSM stateMachine)
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
