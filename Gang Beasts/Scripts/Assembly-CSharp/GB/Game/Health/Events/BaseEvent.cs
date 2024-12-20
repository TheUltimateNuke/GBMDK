using System;

namespace GB.Game.Health.Events
{
	public class BaseEvent : EventArgs
	{
		protected HealthTracker _health;

		private bool _used;

		public HealthTracker Health => null;

		public bool Used => false;

		public bool Use()
		{
			return false;
		}

		public virtual void Reset()
		{
		}

		public BaseEvent(HealthTracker target)
		{
		}
	}
}
