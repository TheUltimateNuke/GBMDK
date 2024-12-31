using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class ListAssetSummariesRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public int? PageSize;

		public string SkipToken;
	}
}
