using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.InsightsModels
{
	[Serializable]
	public class InsightsSetStorageRetentionRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public int RetentionDays;
	}
}
