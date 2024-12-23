namespace GB.FSM
{
	public class BaseState
	{
		public string name;

		protected StateMachine stateMachine;

		public BaseState(string name, StateMachine stateMachine)
		{
		}

		public virtual void EnterServer()
		{
		}

		public virtual void UpdateLogicServer()
		{
		}

		public virtual void FixedUpdateLogicServer()
		{
		}

		public virtual void LateUpdateLogicServer()
		{
		}

		public virtual void ExitServer()
		{
		}

		public virtual void EnterClient()
		{
		}

		public virtual void UpdateLogicClient()
		{
		}

		public virtual void FixedUpdateLogicClient()
		{
		}

		public virtual void LateUpdateLogicClient()
		{
		}

		public virtual void ExitClient()
		{
		}
	}
}
