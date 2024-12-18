using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.Environment.Fracturing
{
	public class NetFractureRouter : NetworkBehaviour
	{
		[SerializeField]
		private NetFractureSync[] FractureSyncs;

		private static int kRpcRpc_TriggerClientsideFracture;

		public void AlertFracture(NetFractureSync sync, Vector3 centre, float force)
		{
		}

		[ClientRpc]
		public void Rpc_TriggerClientsideFracture(int fractureIndex, Vector3 centre, float force)
		{
		}

		private void UNetVersion()
		{
		}

		protected static void InvokeRpcRpc_TriggerClientsideFracture(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		public void CallRpc_TriggerClientsideFracture(int fractureIndex, Vector3 centre, float force)
		{
		}

		static NetFractureRouter()
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
