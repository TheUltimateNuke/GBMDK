using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class AddInventoryItemsRequest : PlayFabRequestCommon
	{
		public int? Amount;

		public string CollectionId;

		public Dictionary<string, string> CustomTags;

		public double? DurationInSeconds;

		public EntityKey Entity;

		public string ETag;

		public string IdempotencyId;

		public InventoryItemReference Item;

		public InitialValues NewStackValues;
	}
}
