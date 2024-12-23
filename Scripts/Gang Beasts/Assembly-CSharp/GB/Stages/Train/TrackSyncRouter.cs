using System.Runtime.InteropServices;
using CoreNet.StateSync.Routers;
using CoreNet.StateSync.Syncs;
using UnityEngine.Networking;

namespace GB.Stages.Train
{
	public class TrackSyncRouter : RigidbodySyncRouter
	{
		private TrackSync _syncTrack;

		[SyncVar]
		private byte _targetSync;

		private TrackSyncState xformStageStorage;

		public byte TargetSync
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public byte Network_targetSync
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

		protected override BaseSync GetSync()
		{
			return null;
		}

		[Server]
		protected override void CalculateMappings()
		{
		}

		[Client]
		protected override void UpdateState()
		{
		}

		protected override void PostSyncSet(bool syncing)
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
