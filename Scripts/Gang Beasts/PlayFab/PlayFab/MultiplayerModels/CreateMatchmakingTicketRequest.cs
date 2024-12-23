using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class CreateMatchmakingTicketRequest : PlayFabRequestCommon
	{
		public MatchmakingPlayer Creator;

		public Dictionary<string, string> CustomTags;

		public int GiveUpAfterSeconds;

		public List<EntityKey> MembersToMatchWith;

		public string QueueName;
	}
}
