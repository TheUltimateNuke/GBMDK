using System.Collections.Generic;
using UnityEngine;

namespace CoreNet.Pooling
{
	public class Pool : MonoBehaviour
	{
		public const float BIG_NUMBER = -200f;

		public static readonly Vector3 DEAD_ZONE;

		public GameObject Prefab;

		private Queue<IPooledItem> _InactiveItems;

		[SerializeField]
		private List<GameObject> _Pool;

		public int PoolCount => 0;

		public int FreeItems => 0;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void Add()
		{
		}

		public void Remove()
		{
		}

		public IPooledItem GetNext()
		{
			return null;
		}

		public void EnsurePoolParity()
		{
		}

		private void OnItemRepool(IPooledItem item)
		{
		}
	}
}
