using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
	[Serializable]
	public class UpdateGroupRoleRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public int? ExpectedProfileVersion;

		public EntityKey Group;

		public string RoleId;

		public string RoleName;
	}
}
