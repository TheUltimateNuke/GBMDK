using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LinkKongregateAccountRequest : PlayFabRequestCommon
	{
		public string AuthTicket;

		public Dictionary<string, string> CustomTags;

		public bool? ForceLink;

		public string KongregateId;
	}
}
