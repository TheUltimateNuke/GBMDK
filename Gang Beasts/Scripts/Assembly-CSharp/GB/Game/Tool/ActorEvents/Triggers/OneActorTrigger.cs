using System.Collections.Generic;
using Femur;

namespace GB.Game.Tool.ActorEvents.Triggers
{
	public class OneActorTrigger : TriggerCheck
	{
		private List<Actor> _triggered;

		~OneActorTrigger()
		{
		}

		private void Actor_OnActorDestroyed(Actor obj)
		{
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
