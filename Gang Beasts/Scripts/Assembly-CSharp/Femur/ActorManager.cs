using System.Collections.Generic;
using UnityEngine;

namespace Femur
{
	public class ActorManager : MonoBehaviour
	{
		private Dictionary<Transform, Actor> m_ActorTransforms;

		public static ActorManager Instance { get; private set; }

		private void Awake()
		{
		}

		public void AddActorTransform(Transform actorTransform, Actor actor)
		{
		}

		public void RemoveActorTransform(Transform actorTransform)
		{
		}

		public bool ContainsActor(Transform actorTransform)
		{
			return false;
		}

		public Actor GetActor(Transform actorTransform)
		{
			return null;
		}
	}
}
