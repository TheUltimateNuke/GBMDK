using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LoginWithAppleRequest : PlayFabRequestCommon
	{
		public bool? CreateAccount;

		public Dictionary<string, string> CustomTags;

		public string EncryptedRequest;

		public string IdentityToken;

		public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

		public string PlayerSecret;

		public string TitleId;
	}
}
