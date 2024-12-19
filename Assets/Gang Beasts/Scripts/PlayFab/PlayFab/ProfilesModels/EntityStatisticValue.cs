using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
	[Serializable]
	public class EntityStatisticValue : PlayFabBaseModel
	{
		public Dictionary<string, EntityStatisticChildValue> ChildStatistics;

		public string Metadata;

		public string Name;

		public int? Value;

		public int Version;
	}
}
