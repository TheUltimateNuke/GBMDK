using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LinkSteamAccountRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public bool? ForceLink;

		public string SteamTicket;
	}
}
