using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class GetItemReviewsRequest : PlayFabRequestCommon
	{
		public CatalogAlternateId AlternateId;

		public string ContinuationToken;

		public int Count;

		public Dictionary<string, string> CustomTags;

		public string Id;

		public string OrderBy;
	}
}
