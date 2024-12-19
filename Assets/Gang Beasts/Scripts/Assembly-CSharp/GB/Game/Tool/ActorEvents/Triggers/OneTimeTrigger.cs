using Femur;

namespace GB.Game.Tool.ActorEvents.Triggers
{
	public class OneTimeTrigger : TriggerCheck
	{
		private bool _triggered;

		public override bool Active()
		{
			return false;
		}

		public override bool Blocked(Actor actor)
		{
			return false;
		}

		public override bool Trigger(Actor actor)
		{
			return false;
		}
	}
}
