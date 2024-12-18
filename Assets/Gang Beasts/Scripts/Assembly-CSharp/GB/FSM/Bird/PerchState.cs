using GB.Game.Critters;

namespace GB.FSM.Bird
{
	public class PerchState : BirdFSMState
	{
		private BirdActor actorRef;

		private float perchActionTime;

		public PerchState(BirdFSM stateMachine)
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
