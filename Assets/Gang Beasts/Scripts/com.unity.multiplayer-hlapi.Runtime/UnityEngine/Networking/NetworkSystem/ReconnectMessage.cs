using System;

namespace UnityEngine.Networking.NetworkSystem
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class ReconnectMessage : MessageBase
	{
		public int oldConnectionId;

		public short playerControllerId;

		public NetworkInstanceId netId;

		public int msgSize;

		public byte[] msgData;

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}
	}
}
