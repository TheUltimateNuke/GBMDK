using System;

namespace UnityEngine.Networking.NetworkSystem
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class PeerInfoMessage : MessageBase
	{
		public int connectionId;

		public string address;

		public int port;

		public bool isHost;

		public bool isYou;

		public PeerInfoPlayer[] playerIds;

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
