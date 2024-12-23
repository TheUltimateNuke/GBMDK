using System;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class NetworkMessage
	{
		public const int MaxMessageSize = 65535;

		public short msgType;

		public NetworkConnection conn;

		public NetworkReader reader;

		public int channelId;

		public static string Dump(byte[] payload, int sz)
		{
			return null;
		}

		public TMsg ReadMessage<TMsg>() where TMsg : MessageBase, new()
		{
			return null;
		}

		public void ReadMessage<TMsg>(TMsg msg) where TMsg : MessageBase
		{
		}
	}
}
