using CoreNet.Objects;
using UnityEngine.Networking;

namespace CoreNet.Messaging.Messages
{
	public class NetItemMessage<T> : NetModelMessage where T : NetObject, new()
	{
		public bool Force;

		public T Payload;

		public NetItemMessage()
		{
		}

		public NetItemMessage(string key, T payload, bool force = false)
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
