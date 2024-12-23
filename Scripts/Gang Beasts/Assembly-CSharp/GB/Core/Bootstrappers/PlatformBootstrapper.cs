using Bootstrap;
using CS.CorePlatform;
using GB.Data.Loading;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GB.Core.Bootstrappers
{
	public class PlatformBootstrapper : Bootstrapper
	{
		public const string PLATFORM_CACHE = "Platform";

		private static bool _startActive;

		private static ICompleteTracker _loadingTracker;

		private static GameObject platformCarrier;

		private static BasePlatformManager newplatform;

		private static bool _dataSetup;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static void ForceStart(bool disable)
		{
		}

		private static void OnResourceLoaded(AsyncOperationStatus status, AssetReference item, object data)
		{
		}

		private static object LoadData(string arg)
		{
			return null;
		}

		protected override void Bootstrap()
		{
		}

		private static bool LoadAssets()
		{
			return false;
		}

		private static void SetupDataInformation()
		{
		}

		private static void SetupObject()
		{
		}

		private static void SetupCSPlatform()
		{
		}

		private static void SetupNone()
		{
		}

		private static void OnOnlineConnectionLost()
		{
		}

		private static void OnLanguageChanged(Locale locale = null)
		{
		}

		public static void PauseGame(bool on)
		{
		}

		public static void OnSystemAwaken()
		{
		}
	}
}
