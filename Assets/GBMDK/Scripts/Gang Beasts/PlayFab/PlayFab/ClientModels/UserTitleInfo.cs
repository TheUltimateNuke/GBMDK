using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class UserTitleInfo : PlayFabBaseModel
	{
		public string AvatarUrl;

		public DateTime Created;

		public string DisplayName;

		public DateTime? FirstLogin;

		public bool? isBanned;

		public DateTime? LastLogin;

		public UserOrigination? Origination;

		public EntityKey TitlePlayerAccount;
	}
}
