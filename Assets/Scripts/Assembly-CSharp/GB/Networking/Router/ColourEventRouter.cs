using UnityEngine;
using UnityEngine.Networking;

namespace GB.Networking.Router
{
	public class ColourEventRouter : NetworkBehaviour
	{
		private EventLogic<Color> _logic;

		private static int kRpcRpc_Trigger;

		public EventLogic<Color> Logic => null;

		[Server]
		public void Trigger(int key, Color value)
		{
		}

		[ClientRpc]
		private void Rpc_Trigger(int key, Color value)
		{
		}

		private void UNetVersion()
		{
		}

		protected static void InvokeRpcRpc_Trigger(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		public void CallRpc_Trigger(int key, Color value)
		{
		}

		static ColourEventRouter()
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
