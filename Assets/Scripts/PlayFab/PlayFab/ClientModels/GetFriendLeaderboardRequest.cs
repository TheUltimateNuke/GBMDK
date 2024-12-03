using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetFriendLeaderboardRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public ExternalFriendSources? ExternalPlatformFriends;

		public int? MaxResultsCount;

		public PlayerProfileViewConstraints ProfileConstraints;

		public int StartPosition;

		public string StatisticName;

		public int? Version;

		public string XboxToken;
	}
}
