using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class AddInventoryItemsOperation : PlayFabBaseModel
	{
		public int? Amount;

		public double? DurationInSeconds;

		public InventoryItemReference Item;

		public InitialValues NewStackValues;
	}
}
