using GB.Game.Health.Effects;
using GB.Game.Health.Events;
using UnityEngine;

namespace GB.Game.Health
{
	public class BreakJointsOnDeath : MonoBehaviour, DeathEffect
	{
		[SerializeField]
		private Joint[] _breakJoints;

		[SerializeField]
		private bool _serverOnly;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void OnDeath(DeathEvent arg)
		{
		}
	}
}
