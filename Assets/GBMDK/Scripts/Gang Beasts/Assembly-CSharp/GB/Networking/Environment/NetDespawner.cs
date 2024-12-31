using System.Collections.Generic;
using CoreNet.StateSync.Routers;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Networking.Environment
{
	[RequireComponent(typeof(NetworkIdentity))]
	public class NetDespawner : MonoBehaviour
	{
		[SerializeField]
		private List<DespawningChild> ChildrenToDespawn;

		[SerializeField]
		private bool DespawnAll;

		[Range(0f, 1f)]
		[SerializeField]
		private float DespawnAllChance;

		private bool _Initialised;

		public void Start()
		{
		}

		public void AddDespawningChild(BaseSyncRouter child, float chance = 0.5f)
		{
		}

		public void ClearAllChildren()
		{
		}
	}
}
