using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LinkFacebookInstantGamesIdRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string FacebookInstantGamesSignature;

		public bool? ForceLink;
	}
}
