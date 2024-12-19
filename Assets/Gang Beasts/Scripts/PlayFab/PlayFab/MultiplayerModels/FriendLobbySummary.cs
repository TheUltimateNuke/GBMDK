using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class FriendLobbySummary : PlayFabBaseModel
	{
		public string ConnectionString;

		public uint CurrentPlayers;

		public List<EntityKey> Friends;

		public string LobbyId;

		public uint MaxPlayers;

		public MembershipLock? MembershipLock;

		public EntityKey Owner;

		public Dictionary<string, string> SearchData;
	}
}
