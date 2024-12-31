using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetLeaderboardAroundCharacterRequest : PlayFabRequestCommon
	{
		public string CharacterId;

		public int? MaxResultsCount;

		public string StatisticName;
	}
}
