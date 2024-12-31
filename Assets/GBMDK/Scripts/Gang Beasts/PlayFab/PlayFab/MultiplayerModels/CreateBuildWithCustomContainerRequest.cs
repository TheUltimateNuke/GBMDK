using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class CreateBuildWithCustomContainerRequest : PlayFabRequestCommon
	{
		public bool? AreAssetsReadonly;

		public string BuildName;

		public ContainerFlavor? ContainerFlavor;

		public ContainerImageReference ContainerImageReference;

		public string ContainerRunCommand;

		public Dictionary<string, string> CustomTags;

		public List<AssetReferenceParams> GameAssetReferences;

		public List<GameCertificateReferenceParams> GameCertificateReferences;

		public LinuxInstrumentationConfiguration LinuxInstrumentationConfiguration;

		public Dictionary<string, string> Metadata;

		public MonitoringApplicationConfigurationParams MonitoringApplicationConfiguration;

		public int MultiplayerServerCountPerVm;

		public List<Port> Ports;

		public List<BuildRegionParams> RegionConfigurations;

		public ServerResourceConstraintParams ServerResourceConstraints;

		[Obsolete("Use '' instead", false)]
		public bool? UseStreamingForAssetDownloads;

		public AzureVmSize? VmSize;

		public VmStartupScriptParams VmStartupScriptConfiguration;
	}
}
