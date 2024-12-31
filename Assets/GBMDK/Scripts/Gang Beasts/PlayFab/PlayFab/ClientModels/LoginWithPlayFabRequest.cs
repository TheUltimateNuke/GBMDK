using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LoginWithPlayFabRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

		public string Password;

		public string TitleId;

		public string Username;
	}
}
