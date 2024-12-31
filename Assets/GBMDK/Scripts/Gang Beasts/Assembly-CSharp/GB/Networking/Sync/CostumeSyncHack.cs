using System.Collections.Generic;
using CoreNet.StateSync;
using CoreNet.StateSync.Routers;
using UnityEngine;

namespace GB.Networking.Sync
{
	[RequireComponent(typeof(ActorCostume))]
	[RequireComponent(typeof(LazySyncModel))]
	public class CostumeSyncHack : MonoBehaviour
	{
		private List<RigidbodySyncRouter> _Routers;

		private ActorCostume _costume;

		public void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		private void OnCostumeSet()
		{
		}
	}
}
