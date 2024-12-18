using Femur;
using UnityEngine;

namespace GB.Game.Health.Events
{
	public class DeathEvent : BaseEvent
	{
		public Actor actor;

		public InteractableObject interactable;

		public Collision collision;

		public DeathEvent(HealthTracker target)
			: base(null)
		{
		}

		public override void Reset()
		{
		}
	}
}
