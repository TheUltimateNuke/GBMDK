using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class GetBuildResponse : PlayFabResultCommon
	{
		public bool? AreAssetsReadonly;

		public string BuildId;

		public string BuildName;

		public string BuildStatus;

		public ContainerFlavor? ContainerFlavor;

		public string ContainerRunCommand;

		public DateTime? CreationTime;

		public ContainerImageReference CustomGameContainerImage;

		public List<AssetReference> GameAssetReferences;

		public List<GameCertificateReference> GameCertificateReferences;

		public InstrumentationConfiguration InstrumentationConfiguration;

		public Dictionary<string, string> Metadata;

		public int MultiplayerServerCountPerVm;

		public string OsPlatform;

		public List<Port> Ports;

		public List<BuildRegion> RegionConfigurations;

		public ServerResourceConstraintParams ServerResourceConstraints;

		public string ServerType;

		public string StartMultiplayerServerCommand;

		public AzureVmSize? VmSize;

		public VmStartupScriptConfiguration VmStartupScriptConfiguration;
	}
}
