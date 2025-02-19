using System;
using System.Collections.Generic;
using Femur;
using UnityEngine;

namespace GB.Game.AI
{
	public class AIBehaviourBase : MonoBehaviour
	{
		protected List<TargetObjective> _targetPool;

		[SerializeField]
		protected int _targetObjectivePoolStartSize;

		public Action<Actor> OnBehaviourComplete;

		[HideInInspector]
		public bool isComplete;

		protected virtual void Awake()
		{
		}

		public virtual void ExecuteBehaviour(Actor actor)
		{
		}

		protected TargetObjective GetObjectiveHandler()
		{
			return null;
		}
	}
}
