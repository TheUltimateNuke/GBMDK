using GB.Game.Health.Events;

namespace GB.Game.Health.Effects
{
	public interface ResurrectedEffect
	{
		void OnResurrected(ChangeEvent arg);
	}
}
