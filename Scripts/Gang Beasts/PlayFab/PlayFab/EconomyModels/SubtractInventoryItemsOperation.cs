using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class SubtractInventoryItemsOperation : PlayFabBaseModel
	{
		public int? Amount;

		public bool DeleteEmptyStacks;

		public double? DurationInSeconds;

		public InventoryItemReference Item;
	}
}
