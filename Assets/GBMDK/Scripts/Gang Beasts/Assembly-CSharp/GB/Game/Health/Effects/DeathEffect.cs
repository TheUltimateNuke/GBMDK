using GB.Game.Health.Events;

namespace GB.Game.Health.Effects
{
	public interface DeathEffect
	{
		void OnDeath(DeathEvent arg);
	}
}
