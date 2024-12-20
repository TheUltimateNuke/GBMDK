using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class ReportItemRequest : PlayFabRequestCommon
	{
		public CatalogAlternateId AlternateId;

		public ConcernCategory? ConcernCategory;

		public Dictionary<string, string> CustomTags;

		public EntityKey Entity;

		public string Id;

		public string Reason;
	}
}
