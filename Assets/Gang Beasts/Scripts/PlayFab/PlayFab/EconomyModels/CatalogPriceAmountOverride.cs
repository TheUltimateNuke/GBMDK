using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class CatalogPriceAmountOverride : PlayFabBaseModel
	{
		public int? FixedValue;

		public string ItemId;

		public double? Multiplier;
	}
}
