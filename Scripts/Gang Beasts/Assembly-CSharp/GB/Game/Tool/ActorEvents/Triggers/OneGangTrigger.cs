using System.Collections.Generic;
using Femur;

namespace GB.Game.Tool.ActorEvents.Triggers
{
	public class OneGangTrigger : TriggerCheck
	{
		private List<int> _triggered;

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
