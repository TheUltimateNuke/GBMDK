using System;
using System.Collections.Generic;
using Femur;
using UnityEngine;

namespace GB.Utils
{
	[Serializable]
	internal class ActorPartPresence
	{
		private const int kActorPartsPresentReserveSize = 30;

		public Actor ParentRef;

		[SerializeField]
		private List<GameObject> ActorPartsPresent;

		public ActorPartPresence(Actor act, GameObject firstPart)
		{
		}

		public void AddPart(GameObject part)
		{
		}

		public bool RemovePart(GameObject part)
		{
			return false;
		}

		public void Reset()
		{
		}
	}
}
