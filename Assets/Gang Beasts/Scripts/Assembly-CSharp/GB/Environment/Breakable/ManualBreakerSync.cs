using UnityEngine;
using UnityEngine.Networking;

namespace GB.Environment.Breakable
{
	public class ManualBreakerSync : NetworkBehaviour
	{
		[SerializeField]
		private ManualBreaker _breaker;

		private static int kRpcRpcBreakClient;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnBroken(IBreakable brokenObject, object info)
		{
		}

		[ClientRpc]
		private void RpcBreakClient(int index)
		{
		}

		private void UNetVersion()
		{
		}

		protected static void InvokeRpcRpcBreakClient(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		public void CallRpcBreakClient(int index)
		{
		}

		static ManualBreakerSync()
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
