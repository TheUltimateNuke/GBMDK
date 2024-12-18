using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class Lobby : PlayFabBaseModel
	{
		public AccessPolicy AccessPolicy;

		public uint ChangeNumber;

		public string ConnectionString;

		public Dictionary<string, string> LobbyData;

		public string LobbyId;

		public uint MaxPlayers;

		public List<Member> Members;

		public MembershipLock MembershipLock;

		public EntityKey Owner;

		public OwnerMigrationPolicy? OwnerMigrationPolicy;

		public string PubSubConnectionHandle;

		public Dictionary<string, string> SearchData;

		public bool UseConnections;
	}
}
