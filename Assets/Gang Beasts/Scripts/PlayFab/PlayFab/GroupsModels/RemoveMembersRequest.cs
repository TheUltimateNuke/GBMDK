using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
	[Serializable]
	public class RemoveMembersRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public EntityKey Group;

		public List<EntityKey> Members;

		public string RoleId;
	}
}
