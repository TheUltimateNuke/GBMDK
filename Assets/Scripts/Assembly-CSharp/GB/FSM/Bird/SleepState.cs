using GB.Game.Critters;

namespace GB.FSM.Bird
{
	public class SleepState : BirdFSMState
	{
		private BirdActor actorRef;

		public SleepState(BirdFSM stateMachine)
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
