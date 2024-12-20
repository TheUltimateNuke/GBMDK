using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Stages.Wheel
{
	public class PierSoundRouter : NetworkBehaviour
	{
		[SerializeField]
		private List<RandomPierBreak> breaks;

		private static int kRpcRpc_TriggerAudio;

		public void PlaySound(RandomPierBreak point, int sound, float pitch, bool breakSound)
		{
		}

		[ClientRpc]
		public void Rpc_TriggerAudio(int index, int clip, float pitch, bool breakSound)
		{
		}

		private void UNetVersion()
		{
		}

		protected static void InvokeRpcRpc_TriggerAudio(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		public void CallRpc_TriggerAudio(int index, int clip, float pitch, bool breakSound)
		{
		}

		static PierSoundRouter()
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
