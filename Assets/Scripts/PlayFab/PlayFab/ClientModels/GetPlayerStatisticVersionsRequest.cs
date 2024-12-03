using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPlayerStatisticVersionsRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string StatisticName;
	}
}
