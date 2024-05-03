using System;
using CoreNet.StateSync.Routers;
using UnityEngine;

namespace GB.Networking.Environment
{
	[Serializable]
	public class DespawningChild
	{
		public GameObject ChildObject;

		public float DespawnChance;

		public BaseSyncRouter ChildRouter;

		public DespawningChild(GameObject obj, float chance)
		{
		}
	}
}
