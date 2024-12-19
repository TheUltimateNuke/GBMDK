using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
	[Serializable]
	public class GetTreatmentAssignmentRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public EntityKey Entity;
	}
}
