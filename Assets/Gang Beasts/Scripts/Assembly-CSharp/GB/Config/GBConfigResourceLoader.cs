using UnityEngine;

namespace GB.Config
{
	public class GBConfigResourceLoader : MonoBehaviour
	{
		public const string CONFIG_TAG = "GBConfig";

		public static GBConfigData _configData;

		public static string RegionVersion;

		public static GBConfigData ConfigData => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public void Awake()
		{
		}

		private static void LoadData()
		{
		}

		public static string GetVersion()
		{
			return null;
		}
	}
}
