using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LinkOpenIdConnectRequest : PlayFabRequestCommon
	{
		public string ConnectionId;

		public Dictionary<string, string> CustomTags;

		public bool? ForceLink;

		public string IdToken;
	}
}
