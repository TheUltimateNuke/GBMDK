using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
	[Serializable]
	public class AcceptGroupInvitationRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public EntityKey Entity;

		public EntityKey Group;
	}
}