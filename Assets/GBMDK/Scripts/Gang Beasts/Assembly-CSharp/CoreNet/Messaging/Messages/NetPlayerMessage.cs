using CoreNet.Objects;
using UnityEngine.Networking;

namespace CoreNet.Messaging.Messages
{
	public class NetPlayerMessage<T> : MessageBase where T : NetPlayer, new()
	{
		public T Player;

		public NetPlayerMessage()
		{
		}

		public NetPlayerMessage(T player)
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
