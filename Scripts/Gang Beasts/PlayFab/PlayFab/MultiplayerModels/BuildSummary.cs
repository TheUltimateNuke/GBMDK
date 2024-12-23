using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class BuildSummary : PlayFabBaseModel
	{
		public string BuildId;

		public string BuildName;

		public DateTime? CreationTime;

		public Dictionary<string, string> Metadata;

		public List<BuildRegion> RegionConfigurations;
	}
}
