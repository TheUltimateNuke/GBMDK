using Femur;
using GB.Game.Tool.ActorEvents;
using GB.Utils;
using UnityEngine;

namespace GB.Game.Tool
{
	public class JumpPad : MonoBehaviour, IActorOnTriggerEvent
	{
		[EnumUtils.EnumFlags]
		[SerializeField]
		private Actor.ControlledTypes _neededMode;

		[SerializeField]
		private bool _immortalEffected;

		[SerializeField]
		private bool _needsImmortal;

		[SerializeField]
		private bool _invulnerableEffected;

		[SerializeField]
		private bool _needsInvulnerable;

		[SerializeField]
		private bool _stateEffected;

		[EnumUtils.EnumFlags]
		[SerializeField]
		private Actor.ActorState _needsState;

		[SerializeField]
		private Transform _landTarget;

		[SerializeField]
		private Vector2 _force;

		[SerializeField]
		private ForceMode type;

		private bool CanUse(Actor actor)
		{
			return false;
		}

		public void Event(Actor actor)
		{
		}
	}
}
