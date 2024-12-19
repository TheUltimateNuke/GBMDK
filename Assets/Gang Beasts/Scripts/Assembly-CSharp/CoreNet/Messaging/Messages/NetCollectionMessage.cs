using CoreNet.Objects;
using UnityEngine.Networking;

namespace CoreNet.Messaging.Messages
{
	public class NetCollectionMessage<T> : NetModelMessage where T : NetObject, new()
	{
		public bool Force;

		public int Index;

		public int Operation;

		public T Payload;

		public NetCollectionMessage()
		{
		}

		public NetCollectionMessage(string key, int index, int operation, T payload, bool force = false)
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
