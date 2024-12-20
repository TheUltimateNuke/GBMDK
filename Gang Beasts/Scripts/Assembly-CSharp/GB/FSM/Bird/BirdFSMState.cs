namespace GB.FSM.Bird
{
	public class BirdFSMState : BaseState
	{
		protected BirdFSM birdMachine;

		private BirdFSM.BirdStateID stateID;

		public BirdFSM.BirdStateID GetID()
		{
			return default(BirdFSM.BirdStateID);
		}

		public BirdFSMState(string name, BirdFSM stateMachine, BirdFSM.BirdStateID thisStateID)
			: base(null, null)
		{
		}

		public override void EnterServer()
		{
		}
	}
}
