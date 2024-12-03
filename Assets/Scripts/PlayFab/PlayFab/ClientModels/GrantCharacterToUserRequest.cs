using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GrantCharacterToUserRequest : PlayFabRequestCommon
	{
		public string CatalogVersion;

		public string CharacterName;

		public Dictionary<string, string> CustomTags;

		public string ItemId;
	}
}
