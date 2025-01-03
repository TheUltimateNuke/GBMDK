using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
	[Serializable]
	public class ChangeMemberRoleRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string DestinationRoleId;

		public EntityKey Group;

		public List<EntityKey> Members;

		public string OriginRoleId;
	}
}
