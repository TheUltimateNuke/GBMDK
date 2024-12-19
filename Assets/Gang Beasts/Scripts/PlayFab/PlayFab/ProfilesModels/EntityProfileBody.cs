using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
	[Serializable]
	public class EntityProfileBody : PlayFabBaseModel
	{
		public string AvatarUrl;

		public DateTime Created;

		public string DisplayName;

		public EntityKey Entity;

		public string EntityChain;

		public List<string> ExperimentVariants;

		public Dictionary<string, EntityProfileFileMetadata> Files;

		public string Language;

		public string LeaderboardMetadata;

		public EntityLineage Lineage;

		public Dictionary<string, EntityDataObject> Objects;

		public List<EntityPermissionStatement> Permissions;

		public Dictionary<string, EntityStatisticValue> Statistics;

		public int VersionNumber;
	}
}
