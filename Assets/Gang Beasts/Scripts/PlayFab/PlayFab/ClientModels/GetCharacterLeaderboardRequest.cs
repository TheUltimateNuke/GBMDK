using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetCharacterLeaderboardRequest : PlayFabRequestCommon
	{
		public int? MaxResultsCount;

		public int StartPosition;

		public string StatisticName;
	}
}
