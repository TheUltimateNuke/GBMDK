using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class PayForPurchaseRequest : PlayFabRequestCommon
	{
		public string Currency;

		public Dictionary<string, string> CustomTags;

		public string OrderId;

		public string ProviderName;

		public string ProviderTransactionId;
	}
}
