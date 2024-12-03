using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class CreateBuildWithProcessBasedServerRequest : PlayFabRequestCommon
	{
		public bool? AreAssetsReadonly;

		public string BuildName;

		public Dictionary<string, string> CustomTags;

		public List<AssetReferenceParams> GameAssetReferences;

		public List<GameCertificateReferenceParams> GameCertificateReferences;

		public string GameWorkingDirectory;

		public InstrumentationConfiguration InstrumentationConfiguration;

		public bool? IsOSPreview;

		public Dictionary<string, string> Metadata;

		public MonitoringApplicationConfigurationParams MonitoringApplicationConfiguration;

		public int MultiplayerServerCountPerVm;

		public string OsPlatform;

		public List<Port> Ports;

		public List<BuildRegionParams> RegionConfigurations;

		public string StartMultiplayerServerCommand;

		[Obsolete("Use '' instead", false)]
		public bool? UseStreamingForAssetDownloads;

		public AzureVmSize? VmSize;

		public VmStartupScriptParams VmStartupScriptConfiguration;
	}
}
