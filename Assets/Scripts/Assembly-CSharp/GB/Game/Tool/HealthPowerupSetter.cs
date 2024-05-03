using Femur;
using GB.Game.Tool.ActorEvents;
using UnityEngine;

namespace GB.Game.Tool
{
	public class HealthPowerupSetter : MonoBehaviour, IActorOnTriggerEvent
	{
		[SerializeField]
		private bool _setInvulnerable;

		[SerializeField]
		private bool _giveInvulnerable;

		[SerializeField]
		private bool _setImmortal;

		[SerializeField]
		private bool _giveImmortal;

		public void Event(Actor actor)
		{
		}
	}
}
