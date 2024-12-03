using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class ReportPlayerClientRequest : PlayFabRequestCommon
	{
		public string Comment;

		public Dictionary<string, string> CustomTags;

		public string ReporteeId;
	}
}
