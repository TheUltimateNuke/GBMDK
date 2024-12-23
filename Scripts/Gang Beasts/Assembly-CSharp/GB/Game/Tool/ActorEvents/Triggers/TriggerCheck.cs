using Femur;

namespace GB.Game.Tool.ActorEvents.Triggers
{
	public class TriggerCheck : ITriggerBase
	{
		public virtual bool Active()
		{
			return false;
		}

		public virtual bool Blocked(Actor actor)
		{
			return false;
		}

		public virtual bool Trigger(Actor actor)
		{
			return false;
		}
	}
}
