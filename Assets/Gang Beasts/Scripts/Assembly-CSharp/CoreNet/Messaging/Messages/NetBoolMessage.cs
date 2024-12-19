using UnityEngine.Networking;

namespace CoreNet.Messaging.Messages
{
	public class NetBoolMessage : MessageBase
	{
		public bool Value;

		public NetBoolMessage()
		{
		}

		public NetBoolMessage(bool value)
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
