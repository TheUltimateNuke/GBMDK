using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetFriendsListRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public ExternalFriendSources? ExternalPlatformFriends;

		public PlayerProfileViewConstraints ProfileConstraints;

		public string XboxToken;
	}
}
