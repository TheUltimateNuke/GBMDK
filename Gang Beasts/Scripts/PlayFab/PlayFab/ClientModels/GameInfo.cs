using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GameInfo : PlayFabBaseModel
	{
		public string BuildVersion;

		public string GameMode;

		public string GameServerData;

		public GameInstanceState? GameServerStateEnum;

		public DateTime? LastHeartbeat;

		public string LobbyID;

		public int? MaxPlayers;

		public List<string> PlayerUserIds;

		public Region? Region;

		public uint RunTime;

		public string ServerIPV4Address;

		public string ServerIPV6Address;

		public int? ServerPort;

		public string ServerPublicDNSName;

		public string StatisticName;

		public Dictionary<string, string> Tags;
	}
}
