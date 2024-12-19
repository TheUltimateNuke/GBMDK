using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class GetQueueStatisticsResult : PlayFabResultCommon
	{
		public uint? NumberOfPlayersMatching;

		public Statistics TimeToMatchStatisticsInSeconds;
	}
}
