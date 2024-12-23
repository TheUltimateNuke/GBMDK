using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
	[Serializable]
	public class CreateExperimentRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string Description;

		public DateTime? EndDate;

		public string ExclusionGroupId;

		public uint? ExclusionGroupTrafficAllocation;

		public ExperimentType? ExperimentType;

		public string Name;

		public string SegmentId;

		public DateTime StartDate;

		public List<string> TitlePlayerAccountTestIds;

		public List<Variant> Variants;
	}
}
