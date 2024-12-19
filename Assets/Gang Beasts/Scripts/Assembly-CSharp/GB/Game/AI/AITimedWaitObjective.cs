using System.Collections.Generic;
using Femur;
using GB.Game.Tool.ActorEvents;
using UnityEngine;

namespace GB.Game.AI
{
	public class AITimedWaitObjective : MonoBehaviour, IActorOnTriggerEvent
	{
		private List<TargetObjective> _targetPool;

		[SerializeField]
		private int _poolStartSize;

		[SerializeField]
		private float _waitDuration;

		private void Start()
		{
		}

		private TargetObjective GetObjectiveHandler()
		{
			return null;
		}

		private void WaitObjective(Actor newActor)
		{
		}

		private void OnObjectiveComplete(Actor actor, TargetObjective objective)
		{
		}

		public void Event(Actor actor)
		{
		}
	}
}
