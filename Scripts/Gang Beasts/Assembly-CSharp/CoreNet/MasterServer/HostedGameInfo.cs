using System;
using CoreNet.Messages;
using UnityEngine.Networking;

namespace CoreNet.MasterServer
{
	[Serializable]
	public class HostedGameInfo
	{
		public string IPAddress;

		public int Port;

		public string GameName;

		public string ModeName;

		public string MapName;

		public int CurrentPlayers;

		public int MaxPlayers;

		public bool IsPassworded;

		public bool IsOfficial;

		public float TimeSinceUpdate;

		public NetworkConnection RelatedConnection;

		public HostedGameInfo()
		{
		}

		public HostedGameInfo(GameInfoMessage msg)
		{
		}

		public HostedGameInfo(SmallerGameInfoMessage msg)
		{
		}

		public HostedGameInfo(Server serv)
		{
		}
	}
}
