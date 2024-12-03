using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class ReviewItemRequest : PlayFabRequestCommon
	{
		public CatalogAlternateId AlternateId;

		public Dictionary<string, string> CustomTags;

		public EntityKey Entity;

		public string Id;

		public Review Review;
	}
}
