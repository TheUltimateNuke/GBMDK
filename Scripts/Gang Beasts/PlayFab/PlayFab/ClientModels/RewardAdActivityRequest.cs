using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class RewardAdActivityRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string PlacementId;

		public string RewardId;
	}
}
