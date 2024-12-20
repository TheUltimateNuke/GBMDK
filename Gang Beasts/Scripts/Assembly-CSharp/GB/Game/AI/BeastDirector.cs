using System.Collections.Generic;
using Femur;
using GB.Game.Tool.ActorEvents;
using UnityEngine;

namespace GB.Game.AI
{
	public class BeastDirector : MonoBehaviour, IActorOnTriggerEvent
	{
		[SerializeField]
		private bool _doOnSpawn;

		[SerializeField]
		private List<Transform> _aiMovementNode;

		private Dictionary<GameObject, Actor.ControlledTypes> _controllerStore;

		private List<TargetObjective> _targetPool;

		[SerializeField]
		private int _poolStartSize;

		[SerializeField]
		private OnActorEventBase _onCompleteEventTrigger;

		[SerializeField]
		private bool _refreshCamera;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private TargetObjective GetObjectiveHandler()
		{
			return null;
		}

		private void StartBeastDirecting(Actor newActor)
		{
		}

		public void ReturnControl(Actor actor)
		{
		}

		public void ReturnControl(Actor actor, TargetObjective objective)
		{
		}

		public Transform GetAIMoveToPoint()
		{
			return null;
		}

		public void Event(Actor actor)
		{
		}
	}
}
