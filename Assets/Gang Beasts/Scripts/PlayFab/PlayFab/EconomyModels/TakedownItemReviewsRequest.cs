using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class TakedownItemReviewsRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public List<ReviewTakedown> Reviews;
	}
}
