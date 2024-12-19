using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class PurchaseInventoryItemsOperation : PlayFabBaseModel
	{
		public int? Amount;

		public bool DeleteEmptyStacks;

		public double? DurationInSeconds;

		public InventoryItemReference Item;

		public InitialValues NewStackValues;

		public List<PurchasePriceAmount> PriceAmounts;

		public string StoreId;
	}
}
