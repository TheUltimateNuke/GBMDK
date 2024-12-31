using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class EnableMultiplayerServersForTitleRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;
	}
}