using CoreNet.Objects;
using UnityEngine;

namespace CoreNet.Pooling
{
	[RequireComponent(typeof(Pool))]
	public class PoolSpawner : MonoBehaviour
	{
		public float DelayMin;

		public float DelayMax;

		public Vector3 RandomSpawnOffset;

		private Pool _Pool;

		private float _timeSinceSpawn;

		private float _nextSpawnTime;

		private bool _subscribedToModel;

		[SerializeField]
		private bool _spawnStarted;

		private bool _gameStarted;

		public bool AutoSpawns => false;

		public bool SpawnStarter
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void Start()
		{
		}

		private void GameStateCheck(NetInt newState)
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void AutoSpawnCheck()
		{
		}

		private bool CanSpawn()
		{
			return false;
		}

		private bool SpawnItem()
		{
			return false;
		}

		public bool ForceSpawn()
		{
			return false;
		}

		public bool TrySpawn()
		{
			return false;
		}

		public void OnDrawGizmosSelected()
		{
		}
	}
}
