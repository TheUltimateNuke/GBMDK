using System;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GB.Data.Loading
{
	[CreateAssetMenu(fileName = "SpawnList", menuName = "Gang Beasts/Data/Spawn List", order = 1)]
	public class SpawnList : ScriptableObject, ILoadedAsset, ICompleteTracker
	{
		public enum SpawnType
		{
			Object = 0,
			Actor = 1
		}

		[Serializable]
		public struct SpawnInfo
		{
			public SpawnType Type;

			public GameObject Item;

			public Vector3 Offset;

			public bool RandomRotate;
		}

		[SerializeField]
		private GameObject _winItem;

		[SerializeField]
		private SpawnInfo[] _spawnables;

		public GameObject WinItem => null;

		public SpawnInfo[] Spawnables => null;

		public bool IsDone => false;

		public AsyncOperationStatus Status => default(AsyncOperationStatus);

		public void LoadData(Action OnComplete = null)
		{
		}

		public bool Loading()
		{
			return false;
		}

		public float PercentComplete()
		{
			return 0f;
		}

		public void Unload()
		{
		}
	}
}
