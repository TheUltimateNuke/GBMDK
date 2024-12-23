using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class UpdatePlayerStatisticsRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public List<StatisticUpdate> Statistics;
	}
}
