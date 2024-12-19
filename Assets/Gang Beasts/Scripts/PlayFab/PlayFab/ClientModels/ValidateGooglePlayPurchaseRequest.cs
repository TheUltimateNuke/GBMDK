using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class ValidateGooglePlayPurchaseRequest : PlayFabRequestCommon
	{
		public string CatalogVersion;

		public string CurrencyCode;

		public Dictionary<string, string> CustomTags;

		public uint? PurchasePrice;

		public string ReceiptJson;

		public string Signature;
	}
}
