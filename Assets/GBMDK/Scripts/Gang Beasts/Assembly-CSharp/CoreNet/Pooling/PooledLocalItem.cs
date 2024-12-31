using System.Runtime.CompilerServices;
using UnityEngine;

namespace CoreNet.Pooling
{
	public class PooledLocalItem : MonoBehaviour, IPooledItem
	{
		protected bool _Active;

		private string _Name;

		public bool Pooled => false;

		public event RepoolHandler OnRepool
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public virtual void OnSpawn()
		{
		}

		public void Repool()
		{
		}

		public virtual void PostSpawn()
		{
		}

		public void SetNamePrefix(string prefix)
		{
		}

		public GameObject GetGameObject()
		{
			return null;
		}
	}
}
