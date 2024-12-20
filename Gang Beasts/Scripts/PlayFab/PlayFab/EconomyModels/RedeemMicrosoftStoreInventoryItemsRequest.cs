using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class RedeemMicrosoftStoreInventoryItemsRequest : PlayFabRequestCommon
	{
		public string CollectionId;

		public string CollectionsIdKey;

		public Dictionary<string, string> CustomTags;

		public EntityKey Entity;

		public string XboxToken;
	}
}
