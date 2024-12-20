using GB.Game.Health.Events;

namespace GB.Game.Health.Effects
{
	public interface ChangeEffect
	{
		void OnChanged(ChangeEvent arg);
	}
}
