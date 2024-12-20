using UnityEngine.Networking;

namespace GB.Networking.Messages
{
	public class NetChatMessage : MessageBase
	{
		public short Controller;

		public bool Value;

		public NetChatMessage()
		{
		}

		public NetChatMessage(short controller, bool value)
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
