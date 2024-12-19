using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class RegisterPlayFabUserRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string DisplayName;

		public string Email;

		public string EncryptedRequest;

		public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

		public string Password;

		public string PlayerSecret;

		public bool? RequireBothUsernameAndEmail;

		public string TitleId;

		public string Username;
	}
}
