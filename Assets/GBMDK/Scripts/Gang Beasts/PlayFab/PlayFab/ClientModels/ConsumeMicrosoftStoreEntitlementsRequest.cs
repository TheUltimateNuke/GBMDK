using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class ConsumeMicrosoftStoreEntitlementsRequest : PlayFabRequestCommon
	{
		public string CatalogVersion;

		public Dictionary<string, string> CustomTags;

		public MicrosoftStorePayload MarketplaceSpecificData;
	}
}
