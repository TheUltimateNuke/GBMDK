using System;

namespace SuperGenius.Scripts.Health
{
	[Serializable]
	public class Health
	{
		public bool NotifyOnDepleted;

		public Action DepletedAction;

		private float _current;

		public float Current => 0f;

		public Health()
		{
		}

		public Health(float amount)
		{
		}

		public bool Modify(float amount)
		{
			return false;
		}

		public bool IsDepleted()
		{
			return false;
		}

		public void NotifyHealthDepleted()
		{
		}
	}
}
