using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LinkedPlatformAccountModel : PlayFabBaseModel
	{
		public string Email;

		public LoginIdentityProvider? Platform;

		public string PlatformUserId;

		public string Username;
	}
}
