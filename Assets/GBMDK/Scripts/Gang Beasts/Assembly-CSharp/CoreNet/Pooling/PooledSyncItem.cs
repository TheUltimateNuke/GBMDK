using System.Runtime.CompilerServices;
using GB.Networking.Router;
using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.Pooling
{
	public abstract class PooledSyncItem : NetworkBehaviour, IPooledItem
	{
		protected bool _Active;

		private string _Name;

		private BlitzBufferTrigger _blitzBufferTrigger;

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

		private void UNetVersion()
		{
		}

		public override bool OnSerialize(NetworkWriter writer, bool forceAll)
		{
			return false;
		}

		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
		}

		public override void PreStartClient()
		{
		}
	}
}
