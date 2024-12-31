using Femur;
using UnityEngine;

namespace GB.Game.Tool.ActorEvents
{
	public class OnTriggerTimedStop : MonoBehaviour, IActorOnTriggerEvent
	{
		[SerializeField]
		private OnTriggerTimedEvent _target;

		[SerializeField]
		private bool _trigger;

		public void Event(Actor actor)
		{
		}
	}
}
