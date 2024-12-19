using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
	[Serializable]
	public class SetProfileLanguageRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public EntityKey Entity;

		public int? ExpectedVersion;

		public string Language;
	}
}
