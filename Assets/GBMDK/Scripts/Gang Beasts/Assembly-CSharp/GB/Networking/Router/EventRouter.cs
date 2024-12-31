using System;
using System.Collections.Generic;
using UnityEngine.Networking;

namespace GB.Networking.Router
{
	public class EventRouter : NetworkBehaviour
	{
		private Dictionary<int, Action> OnTriggerServer;

		private Dictionary<int, Action> OnTriggerClient;

		private static int kRpcRpc_Trigger;

		public void AddServerTrigger(int key, Action action)
		{
		}

		public void AddClientTrigger(int key, Action action)
		{
		}

		public void RemoveServerTrigger(int key, Action action)
		{
		}

		public void RemoveClientTrigger(int key, Action action)
		{
		}

		[Server]
		public void Trigger(int key)
		{
		}

		[ClientRpc]
		private void Rpc_Trigger(int key)
		{
		}

		private void UNetVersion()
		{
		}

		protected static void InvokeRpcRpc_Trigger(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		public void CallRpc_Trigger(int key)
		{
		}

		static EventRouter()
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
