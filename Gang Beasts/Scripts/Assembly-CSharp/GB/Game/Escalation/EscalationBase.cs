using UnityEngine;

namespace GB.Game.Escalation
{
	public abstract class EscalationBase : MonoBehaviour
	{
		[HideInInspector]
		public EscalationType escalationType;

		[HideInInspector]
		public EscalationEvent OnActive;

		protected EscalationManager _manager;

		private void Start()
		{
		}

		private void EscalationManager_OnSetupComplete()
		{
		}

		private void Register()
		{
		}

		public bool TryActivate()
		{
			return false;
		}

		protected virtual void OnInitialize()
		{
		}

		protected virtual bool CanRegister()
		{
			return false;
		}

		protected virtual bool CanActivate()
		{
			return false;
		}

		public virtual void OnUpdate()
		{
		}
	}
}
