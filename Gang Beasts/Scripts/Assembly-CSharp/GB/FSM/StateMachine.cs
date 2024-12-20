using UnityEngine;

namespace GB.FSM
{
	public class StateMachine : MonoBehaviour
	{
		public string StateName;

		protected BaseState currentState;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private void ExitState()
		{
		}

		private void EnterState()
		{
		}

		public virtual void ChangeState(BaseState newState)
		{
		}

		protected virtual BaseState GetInitialState()
		{
			return null;
		}
	}
}
