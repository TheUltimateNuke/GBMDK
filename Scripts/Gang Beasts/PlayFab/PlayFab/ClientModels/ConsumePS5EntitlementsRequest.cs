using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class ConsumePS5EntitlementsRequest : PlayFabRequestCommon
	{
		public string CatalogVersion;

		public Dictionary<string, string> CustomTags;

		public PlayStation5Payload MarketplaceSpecificData;
	}
}
