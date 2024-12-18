using System.Collections.Generic;
using CoreNet.Objects;
using UnityEngine.Networking;

namespace CoreNet.Messaging.Messages
{
	public class NetPlayersMessage<T> : MessageBase where T : NetPlayer, new()
	{
		public T[] Players;

		public NetPlayersMessage()
		{
		}

		public NetPlayersMessage(List<T> players)
		{
		}

		public NetPlayersMessage(T[] players)
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
