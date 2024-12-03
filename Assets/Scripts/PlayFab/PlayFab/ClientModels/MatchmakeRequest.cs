using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class MatchmakeRequest : PlayFabRequestCommon
	{
		public string BuildVersion;

		public string CharacterId;

		public Dictionary<string, string> CustomTags;

		public string GameMode;

		public string LobbyId;

		public Region? Region;

		public bool? StartNewIfNoneFound;

		public string StatisticName;

		public CollectionFilter TagFilter;
	}
}
