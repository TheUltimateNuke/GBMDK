using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class StartPurchaseRequest : PlayFabRequestCommon
	{
		public string CatalogVersion;

		public Dictionary<string, string> CustomTags;

		public List<ItemPurchaseRequest> Items;

		public string StoreId;
	}
}
