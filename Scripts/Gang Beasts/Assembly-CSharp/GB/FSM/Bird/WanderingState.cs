using GB.Game.Critters;

namespace GB.FSM.Bird
{
	public class WanderingState : BirdFSMState
	{
		private BirdActor actorRef;

		private float TimeSinceLastNodeChange;

		public WanderingState(BirdFSM stateMachine)
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
