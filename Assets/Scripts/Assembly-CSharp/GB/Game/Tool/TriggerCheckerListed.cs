using System.Collections.Generic;
using Femur;
using GB.Game.Tool.ActorEvents;
using GB.Game.Tool.ActorEvents.Triggers;
using UnityEngine;

namespace GB.Game.Tool
{
	public class TriggerCheckerListed : MonoBehaviour, ITriggerBase, IActorOnTriggerEvent
	{
		[SerializeField]
		private bool _neededInList;

		private List<Actor> _listed;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Actor_OnActorDestroyed(Actor obj)
		{
		}

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

		public void AddToList(Actor actor)
		{
		}

		public void Event(Actor actor)
		{
		}
	}
}
