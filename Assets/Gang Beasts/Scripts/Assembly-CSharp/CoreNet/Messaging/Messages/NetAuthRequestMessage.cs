using UnityEngine.Networking;

namespace CoreNet.Messaging.Messages
{
	public class NetAuthRequestMessage : MessageBase
	{
		public bool IsMatchmakingJoin;

		public ulong[] PlayerIds;

		public bool RequestPassword;

		public NetAuthRequestMessage()
		{
		}

		public NetAuthRequestMessage(bool isMatchmakingJoin, ulong[] playerIds, bool requestPassword)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}

		public override void Deserialize(NetworkReader reader)
		{
		}
	}
}
