using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
	[Serializable]
	public class GetTitlePlayersFromMasterPlayerAccountIdsRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public List<string> MasterPlayerAccountIds;

		public string TitleId;
	}
}
