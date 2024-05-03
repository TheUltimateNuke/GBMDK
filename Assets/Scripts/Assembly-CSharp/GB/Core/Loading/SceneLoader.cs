using System;
using System.Runtime.CompilerServices;
using Audio;
using GB.Data.Loading;
using GB.Game.Data;
using GB.Networking.Utils.Spawn;
using GB.Setup;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

namespace GB.Core.Loading
{
	public class SceneLoader : MonoBehaviour, IAsyncResourceLoader
	{
		private class NetworkLoading : ILoadingSystem
		{
			private SceneLoader _sceneLoader;

			private SceneLoadTask _loadingLevel;

			public bool IsDone => false;

			public bool IsLoading => false;

			public bool IsWaitingActivation => false;

			public bool IsActivated => false;

			public float Progression => 0f;

			internal NetworkLoading(SceneLoader loader)
			{
			}

			public void ActivateScene()
			{
			}

			public void CompleteLoad()
			{
			}

			public void LoadScene(string map, LoadSceneMode mode)
			{
			}

			public void OnGUI()
			{
			}
		}

		[SerializeField]
		private AssetReference _sceneDataRef;

		[SerializeField]
		private AssetReference _defaultSceneRef;

		private string _currentScene;

		private string _currentKey;

		private IDataCache _sceneList;

		private SceneData _defaultSceneData;

		private SceneData _sceneData;

		private NetworkLoading _networkLoader;

		public string CurrentScene => null;

		public string CurrentKey => null;

		public AssetReference SceneRef => null;

		public SpawnList SpawnList => null;

		public SpawnPatternCarrier SpawnPattern => null;

		public WavesData WavesData => null;

		public RumbleData RumbleData => null;

		public FootballData FootballData => null;

		public IDataCache ModeOverrides => null;

		public SceneAudioConfig SceneAudioConfig => null;

		public SceneAudioConfig DefaultSceneAudioConfig => null;

		public static event Action OnSceneDataLoaded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Awake()
		{
		}

		private void OnSceneUnloaded(Scene arg0)
		{
		}

		private void OnDestroy()
		{
		}

		public void LoadMainMenuWithLoadingScreen(bool setupMenu = true, bool disconnectNetwork = true)
		{
		}

		public SceneLoadTask LoadScene(string key, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return null;
		}

		private void OnSceneLoaded(SceneLoadTask task)
		{
		}

		public void BeginAsyncLoading()
		{
		}

		private void OnSceneListComplete(AsyncOperationStatus result, AssetReference assetRef, object data)
		{
		}

		private void OnDefaultSceneComplete(AsyncOperationStatus result, AssetReference assetRef, object data)
		{
		}

		public bool HasFinishedAsyncLoading()
		{
			return false;
		}
	}
}
