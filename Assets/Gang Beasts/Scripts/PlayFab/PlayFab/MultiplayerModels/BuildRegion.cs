using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class BuildRegion : PlayFabBaseModel
	{
		public CurrentServerStats CurrentServerStats;

		public DynamicStandbySettings DynamicStandbySettings;

		public bool IsAssetReplicationComplete;

		public int MaxServers;

		public int? MultiplayerServerCountPerVm;

		public string Region;

		public ScheduledStandbySettings ScheduledStandbySettings;

		public int StandbyServers;

		public string Status;

		public AzureVmSize? VmSize;
	}
}
