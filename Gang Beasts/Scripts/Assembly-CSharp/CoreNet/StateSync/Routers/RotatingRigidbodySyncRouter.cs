using CoreNet.StateSync.Syncs;
using UnityEngine.Networking;

namespace CoreNet.StateSync.Routers
{
	[NetworkSettings(channel = 1, sendInterval = 0f)]
	public class RotatingRigidbodySyncRouter : RotatingTransformSyncRouter
	{
		protected RotatingRigidbodySync _rigidSync;

		protected override BaseSync GetSync()
		{
			return null;
		}

		private void UNetVersion()
		{
		}

		public override int GetNetworkChannel()
		{
			return 0;
		}

		public override float GetNetworkSendInterval()
		{
			return 0f;
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
