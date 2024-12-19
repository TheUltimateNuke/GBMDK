using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
	[Serializable]
	public class SetGlobalPolicyRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public List<EntityPermissionStatement> Permissions;
	}
}
