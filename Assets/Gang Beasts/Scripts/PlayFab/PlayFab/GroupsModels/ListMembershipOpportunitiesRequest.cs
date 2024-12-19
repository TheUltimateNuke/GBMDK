using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
	[Serializable]
	public class ListMembershipOpportunitiesRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public EntityKey Entity;
	}
}
