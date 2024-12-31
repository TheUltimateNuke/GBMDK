using GB.Data.Loading;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GB.DebugTools
{
	public class GlobalDebug : MonoBehaviour
	{
		public static GlobalDebug instance;

		private IDataCache _resources;

		private AssetReference _resourceRef;

		public IDataCache Resources => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static void CreateDebugManager()
		{
		}

		private void Awake()
		{
		}

		private void OnDataLoaded(AsyncOperationStatus status, AssetReference item, object data)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
