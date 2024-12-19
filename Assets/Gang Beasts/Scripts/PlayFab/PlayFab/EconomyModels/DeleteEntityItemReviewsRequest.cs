using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class DeleteEntityItemReviewsRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public EntityKey Entity;
	}
}
