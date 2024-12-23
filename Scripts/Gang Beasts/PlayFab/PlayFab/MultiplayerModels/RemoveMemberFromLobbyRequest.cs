using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class RemoveMemberFromLobbyRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string LobbyId;

		public EntityKey MemberEntity;

		public bool PreventRejoin;
	}
}
