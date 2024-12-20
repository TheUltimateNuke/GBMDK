using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
	[Serializable]
	public class DeleteExperimentRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string ExperimentId;
	}
}
