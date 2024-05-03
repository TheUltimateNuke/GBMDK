using GB.Networking.Objects;
using UnityEngine.Networking;

namespace GB.Networking.Messages
{
	public class NetPlatformMessage : MessageBase
	{
		public NetPlatform Platform;

		public NetPlatformMessage()
		{
		}

		public NetPlatformMessage(NetPlatform plat)
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
