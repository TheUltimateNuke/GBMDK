using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class CreateTitleMultiplayerServersQuotaChangeRequest : PlayFabRequestCommon
	{
		public string ChangeDescription;

		public List<CoreCapacityChange> Changes;

		public string ContactEmail;

		public Dictionary<string, string> CustomTags;

		public string Notes;

		public DateTime? StartDate;
	}
}
