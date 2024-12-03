using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class JoinMatchmakingTicketRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public MatchmakingPlayer Member;

		public string QueueName;

		public string TicketId;
	}
}
