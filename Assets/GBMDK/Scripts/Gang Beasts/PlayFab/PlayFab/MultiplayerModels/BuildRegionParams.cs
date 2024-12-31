using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class BuildRegionParams : PlayFabBaseModel
	{
		public DynamicStandbySettings DynamicStandbySettings;

		public int MaxServers;

		public int? MultiplayerServerCountPerVm;

		public string Region;

		public ScheduledStandbySettings ScheduledStandbySettings;

		public int StandbyServers;

		public AzureVmSize? VmSize;
	}
}
