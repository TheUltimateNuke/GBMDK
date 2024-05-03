using CoreNet.MasterServer;
using UnityEngine.Networking;

namespace CoreNet.Messages
{
	public class GameInfoMessage : MessageBase
	{
		public string IPAddress;

		public int Port;

		public string GameName;

		public string ModeName;

		public string MapName;

		public int CurrentPlayers;

		public int MaxPlayers;

		public bool IsPassworded;

		public GameInfoMessage()
		{
		}

		public GameInfoMessage(HostedGameInfo info)
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
