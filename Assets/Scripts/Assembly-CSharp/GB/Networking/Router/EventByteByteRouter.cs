using UnityEngine.Networking;

namespace GB.Networking.Router
{
	public class EventByteByteRouter : NetworkBehaviour
	{
		private EventLogic<byte, byte> _logic;

		private static int kRpcRpc_Trigger;

		public EventLogic<byte, byte> Logic => null;

		[Server]
		public void Trigger(int key, byte value1, byte value2)
		{
		}

		[ClientRpc]
		private void Rpc_Trigger(int key, byte value1, byte value2)
		{
		}

		private void UNetVersion()
		{
		}

		protected static void InvokeRpcRpc_Trigger(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		public void CallRpc_Trigger(int key, byte value1, byte value2)
		{
		}

		static EventByteByteRouter()
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
