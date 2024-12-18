using System.Runtime.CompilerServices;
using UnityEngine;

namespace CoreNet.StateSync.Triggers
{
	public abstract class BaseSyncTrigger : MonoBehaviour
	{
		public delegate void SyncHandler();

		protected bool _Syncing;

		public bool Syncing => false;

		public event SyncHandler OnStartSync
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

		public event SyncHandler OnStopSync
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

		public virtual void OverrideSync(bool state)
		{
		}

		public void TriggerStartSync()
		{
		}

		public void TriggerStopSync()
		{
		}
	}
}
