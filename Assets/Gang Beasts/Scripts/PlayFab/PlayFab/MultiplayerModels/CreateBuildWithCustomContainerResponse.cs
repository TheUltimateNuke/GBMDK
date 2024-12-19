using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class CreateBuildWithCustomContainerResponse : PlayFabResultCommon
	{
		public bool? AreAssetsReadonly;

		public string BuildId;

		public string BuildName;

		public ContainerFlavor? ContainerFlavor;

		public string ContainerRunCommand;

		public DateTime? CreationTime;

		public ContainerImageReference CustomGameContainerImage;

		public List<AssetReference> GameAssetReferences;

		public List<GameCertificateReference> GameCertificateReferences;

		public LinuxInstrumentationConfiguration LinuxInstrumentationConfiguration;

		public Dictionary<string, string> Metadata;

		public MonitoringApplicationConfiguration MonitoringApplicationConfiguration;

		public int MultiplayerServerCountPerVm;

		public string OsPlatform;

		public List<Port> Ports;

		public List<BuildRegion> RegionConfigurations;

		public ServerResourceConstraintParams ServerResourceConstraints;

		public string ServerType;

		public bool? UseStreamingForAssetDownloads;

		public AzureVmSize? VmSize;

		public VmStartupScriptConfiguration VmStartupScriptConfiguration;
	}
}
