using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class ValidateWindowsReceiptRequest : PlayFabRequestCommon
	{
		public string CatalogVersion;

		public string CurrencyCode;

		public Dictionary<string, string> CustomTags;

		public uint PurchasePrice;

		public string Receipt;
	}
}
