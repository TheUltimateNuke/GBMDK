using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class ListVirtualMachineSummariesRequest : PlayFabRequestCommon
	{
		public string BuildId;

		public Dictionary<string, string> CustomTags;

		public int? PageSize;

		public string Region;

		public string SkipToken;
	}
}
