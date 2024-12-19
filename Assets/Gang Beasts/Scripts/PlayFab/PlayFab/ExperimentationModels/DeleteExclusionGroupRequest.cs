using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
	[Serializable]
	public class DeleteExclusionGroupRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string ExclusionGroupId;
	}
}
