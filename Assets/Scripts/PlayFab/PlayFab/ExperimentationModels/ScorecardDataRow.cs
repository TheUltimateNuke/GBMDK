using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ExperimentationModels
{
	[Serializable]
	public class ScorecardDataRow : PlayFabBaseModel
	{
		public bool IsControl;

		public Dictionary<string, MetricData> MetricDataRows;

		public uint PlayerCount;

		public string VariantName;
	}
}
