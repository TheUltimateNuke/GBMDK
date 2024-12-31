using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class AddOrUpdateContactEmailRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string EmailAddress;
	}
}
