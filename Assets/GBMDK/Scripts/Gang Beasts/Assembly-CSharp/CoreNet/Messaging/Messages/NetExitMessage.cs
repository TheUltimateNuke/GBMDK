using UnityEngine.Networking;

namespace CoreNet.Messaging.Messages
{
	public class NetExitMessage : MessageBase
	{
		public string Reason;

		public NetExitMessage()
		{
		}

		public NetExitMessage(string reason)
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
