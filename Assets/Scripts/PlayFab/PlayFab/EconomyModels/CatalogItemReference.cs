using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class CatalogItemReference : PlayFabBaseModel
	{
		public int? Amount;

		public string Id;

		public CatalogPriceOptions PriceOptions;
	}
}
