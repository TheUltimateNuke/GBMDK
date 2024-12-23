using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class JoinArrangedLobbyRequest : PlayFabRequestCommon
	{
		public AccessPolicy? AccessPolicy;

		public string ArrangementString;

		public Dictionary<string, string> CustomTags;

		public uint MaxPlayers;

		public Dictionary<string, string> MemberData;

		public EntityKey MemberEntity;

		public OwnerMigrationPolicy? OwnerMigrationPolicy;

		public bool UseConnections;
	}
}
