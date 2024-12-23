using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Networking.Router
{
	public class PhysicsAudioRouter : NetworkBehaviour
	{
		[SerializeField]
		public List<PhysicsAudioData> registeredAudioData;

		private static int kRpcRpc_TriggerAudio;

		public void RegisterEmitterData(PhysicsAudioData adding)
		{
		}

		public void UnregisterEmitterData(PhysicsAudioData adding)
		{
		}

		[Server]
		public void SendEmittionEvent(PhysicsAudioData data, int clip, bool hardImpact, Vector2 contactPos, float volume, float pitch)
		{
		}

		[ClientRpc]
		public void Rpc_TriggerAudio(int index, int clip, bool hardImpact, Vector2 contactPos, float volume, float pitch)
		{
		}

		private void UNetVersion()
		{
		}

		protected static void InvokeRpcRpc_TriggerAudio(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		public void CallRpc_TriggerAudio(int index, int clip, bool hardImpact, Vector2 contactPos, float volume, float pitch)
		{
		}

		static PhysicsAudioRouter()
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
