using UnityEngine.Networking;

namespace GB.Networking.Router
{
	public class BlitzBufferTrigger : NetworkBehaviour
	{
		public PooledObjectSyncTrigger[] _syncTriggers;

		public void PauseSync()
		{
		}

		public void ResumeSync()
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
