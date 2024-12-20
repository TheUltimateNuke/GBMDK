using Femur;
using UnityEngine;

namespace GB.Game.Health.Events
{
	public class ChangeEffectEvent : BaseEvent
	{
		public float multiplayer;

		public float solid;

		public Actor actor;

		public InteractableObject interactable;

		public Collision collision;

		public bool healing;

		public ChangeEffectEvent(HealthTracker target)
			: base(null)
		{
		}

		public override void Reset()
		{
		}
	}
}
