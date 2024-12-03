using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class ReportAdActivityRequest : PlayFabRequestCommon
	{
		public AdActivity Activity;

		public Dictionary<string, string> CustomTags;

		public string PlacementId;

		public string RewardId;
	}
}
