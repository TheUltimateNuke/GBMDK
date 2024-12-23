using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.AuthenticationModels
{
	[Serializable]
	public class ValidateEntityTokenRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string EntityToken;
	}
}
