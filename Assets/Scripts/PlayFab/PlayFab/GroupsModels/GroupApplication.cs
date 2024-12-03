using System;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
	[Serializable]
	public class GroupApplication : PlayFabBaseModel
	{
		public EntityWithLineage Entity;

		public DateTime Expires;

		public EntityKey Group;
	}
}
