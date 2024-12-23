using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LoginWithPSNRequest : PlayFabRequestCommon
	{
		public string AuthCode;

		public bool? CreateAccount;

		public Dictionary<string, string> CustomTags;

		public string EncryptedRequest;

		public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

		public int? IssuerId;

		public string PlayerSecret;

		public string RedirectUri;

		public string TitleId;
	}
}
