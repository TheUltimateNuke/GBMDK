using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class GetDraftItemsRequest : PlayFabRequestCommon
	{
		public List<CatalogAlternateId> AlternateIds;

		public Dictionary<string, string> CustomTags;

		public EntityKey Entity;

		public List<string> Ids;
	}
}
