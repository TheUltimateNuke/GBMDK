using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class SharedGroupDataRecord : PlayFabBaseModel
	{
		public DateTime LastUpdated;

		public string LastUpdatedBy;

		public UserDataPermission? Permission;

		public string Value;
	}
}
