using Femur;
using GB.Game.Tool.ActorEvents.Triggers;
using UnityEngine;

namespace GB.Game.Tool
{
	public class TriggerEnterCheckActorChecker : MonoBehaviour, ITriggerBase
	{
		[SerializeField]
		private bool _needNetBeast;

		[SerializeField]
		private bool _neededNetBeastNull;

		[SerializeField]
		private bool _needAlive;

		[SerializeField]
		private bool _neededAlive;

		[SerializeField]
		private bool _needController;

		[SerializeField]
		private Actor.ControlledTypes _neededController;

		[SerializeField]
		private bool _needGang;

		[SerializeField]
		private int _neededGangID;

		public bool Active()
		{
			return false;
		}

		public bool Blocked(Actor actor)
		{
			return false;
		}

		public bool Trigger(Actor actor)
		{
			return false;
		}
	}
}
