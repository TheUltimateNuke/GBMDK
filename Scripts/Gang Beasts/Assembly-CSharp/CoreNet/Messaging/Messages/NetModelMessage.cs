using UnityEngine.Networking;

namespace CoreNet.Messaging.Messages
{
	public abstract class NetModelMessage : MessageBase
	{
		public string Key;

		public NetModelMessage()
		{
		}

		public NetModelMessage(string key)
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
