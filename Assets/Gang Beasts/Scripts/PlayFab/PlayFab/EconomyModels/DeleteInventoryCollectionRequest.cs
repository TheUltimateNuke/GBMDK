using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class DeleteInventoryCollectionRequest : PlayFabRequestCommon
	{
		public string CollectionId;

		public Dictionary<string, string> CustomTags;

		public EntityKey Entity;

		public string ETag;
	}
}
