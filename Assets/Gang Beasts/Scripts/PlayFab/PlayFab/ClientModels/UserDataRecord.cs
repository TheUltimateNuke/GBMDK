using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class UserDataRecord : PlayFabBaseModel
	{
		public DateTime LastUpdated;

		public UserDataPermission? Permission;

		public string Value;
	}
}
