using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class ConsumePSNEntitlementsRequest : PlayFabRequestCommon
	{
		public string CatalogVersion;

		public Dictionary<string, string> CustomTags;

		public int ServiceLabel;
	}
}
