using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LoginWithEmailAddressRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string Email;

		public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

		public string Password;

		public string TitleId;
	}
}
