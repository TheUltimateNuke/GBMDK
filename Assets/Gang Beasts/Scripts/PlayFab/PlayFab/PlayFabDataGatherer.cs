using UnityEngine;
using UnityEngine.Rendering;

namespace PlayFab
{
	public class PlayFabDataGatherer
	{
		public string ProductName;

		public string ProductBundle;

		public string Version;

		public string Company;

		public RuntimePlatform Platform;

		public bool GraphicsMultiThreaded;

		public GraphicsDeviceType GraphicsType;

		public string DataPath;

		public string PersistentDataPath;

		public string StreamingAssetsPath;

		public int TargetFrameRate;

		public string UnityVersion;

		public bool RunInBackground;

		public string DeviceModel;

		public DeviceType DeviceType;

		public string DeviceUniqueId;

		public string OperatingSystem;

		public int GraphicsDeviceId;

		public string GraphicsDeviceName;

		public int GraphicsMemorySize;

		public int GraphicsShaderLevel;

		public int SystemMemorySize;

		public int ProcessorCount;

		public int ProcessorFrequency;

		public string ProcessorType;

		public bool SupportsAccelerometer;

		public bool SupportsGyroscope;

		public bool SupportsLocationService;

		public string GenerateReport()
		{
			return null;
		}
	}
}
