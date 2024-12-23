using System.Runtime.InteropServices;
using CoreNet.StateSync.Routers;
using UnityEngine.Networking;

namespace GB.Networking.Router
{
	public class PooledObjectSyncRouter : RigidbodySyncRouter
	{
		[SyncVar(hook = "SetTriggerSync")]
		private ushort _triggerSyncs;

		public ushort Network_triggerSyncs
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		public bool GetState(int index)
		{
			return false;
		}

		private void SetTriggerSync(ushort syncing)
		{
		}

		private void UpdateTriggerSync(int i, bool value)
		{
		}

		protected override void Awake()
		{
		}

		protected override void LoadSyncTrigger()
		{
		}

		protected override void OnStartSync()
		{
		}

		protected override void OnStopSync()
		{
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
