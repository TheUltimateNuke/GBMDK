using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class GetDraftItemRequest : PlayFabRequestCommon
	{
		public CatalogAlternateId AlternateId;

		public Dictionary<string, string> CustomTags;

		public EntityKey Entity;

		public string Id;
	}
}
