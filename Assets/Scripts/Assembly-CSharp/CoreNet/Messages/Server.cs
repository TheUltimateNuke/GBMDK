using CoreNet.MasterServer;

namespace CoreNet.Messages
{
	public struct Server
	{
		public string IP;

		public int Port;

		public string GameName;

		public string ModeName;

		public string MapName;

		public int CurrentPlayers;

		public int MaxPlayers;

		public bool IsPassworded;

		public Server(HostedGameInfo info) : this()
        {
		}
	}
}
