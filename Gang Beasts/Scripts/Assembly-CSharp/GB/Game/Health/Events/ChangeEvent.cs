using Femur;
using UnityEngine;

namespace GB.Game.Health.Events
{
	public class ChangeEvent : BaseEvent
	{
		public float change;

		public Actor actor;

		public InteractableObject interactable;

		public Collision collision;

		public ChangeEvent(HealthTracker target)
			: base(null)
		{
		}

		public override void Reset()
		{
		}
	}
}
