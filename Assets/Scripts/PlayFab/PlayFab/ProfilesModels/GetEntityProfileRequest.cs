using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
	[Serializable]
	public class GetEntityProfileRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public bool? DataAsObject;

		public EntityKey Entity;
	}
}
