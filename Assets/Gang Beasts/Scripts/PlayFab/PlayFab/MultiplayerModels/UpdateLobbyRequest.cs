using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class UpdateLobbyRequest : PlayFabRequestCommon
	{
		public AccessPolicy? AccessPolicy;

		public Dictionary<string, string> CustomTags;

		public Dictionary<string, string> LobbyData;

		public List<string> LobbyDataToDelete;

		public string LobbyId;

		public uint? MaxPlayers;

		public Dictionary<string, string> MemberData;

		public List<string> MemberDataToDelete;

		public EntityKey MemberEntity;

		public MembershipLock? MembershipLock;

		public EntityKey Owner;

		public Dictionary<string, string> SearchData;

		public List<string> SearchDataToDelete;
	}
}
