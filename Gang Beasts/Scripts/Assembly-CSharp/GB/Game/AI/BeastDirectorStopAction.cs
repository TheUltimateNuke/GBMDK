using Femur;
using GB.Game.Tool.ActorEvents;
using UnityEngine;

namespace GB.Game.AI
{
	public class BeastDirectorStopAction : MonoBehaviour, IActorOnTriggerEvent
	{
		[SerializeField]
		private BeastDirector _target;

		private void Awake()
		{
		}

		public void Event(Actor actor)
		{
		}
	}
}
