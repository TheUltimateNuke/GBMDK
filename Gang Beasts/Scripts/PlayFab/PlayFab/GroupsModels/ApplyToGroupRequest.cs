using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
	[Serializable]
	public class ApplyToGroupRequest : PlayFabRequestCommon
	{
		public bool? AutoAcceptOutstandingInvite;

		public Dictionary<string, string> CustomTags;

		public EntityKey Entity;

		public EntityKey Group;
	}
}
