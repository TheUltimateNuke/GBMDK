using Femur;

namespace GB.Game.Tool.ActorEvents.Triggers
{
	public interface ITriggerBase
	{
		bool Active();

		bool Blocked(Actor actor);

		bool Trigger(Actor actor);
	}
}
