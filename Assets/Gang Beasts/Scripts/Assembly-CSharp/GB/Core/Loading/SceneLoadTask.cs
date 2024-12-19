using GB.Data.Loading;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace GB.Core.Loading
{
	public class SceneLoadTask : ICompleteTracker
	{
		public delegate void OnLoaded(SceneLoadTask sceneLoaded);

		private LoadSceneMode _loadMode;

		private bool _activateOnLoad;

		private int _priority;

		private OnLoaded _onComplete;

		private AssetReference _sceneDataRef;

		private AssetReference _sceneLoadRef;

		private SceneData _sceneData;

		private SceneInstance _sceneInstance;

		private AsyncOperationStatus _status;

		private ICompleteTracker _dataLoading;

		private AsyncOperationHandle<SceneInstance> _sceneLoading;

		private AsyncOperation _activateLoading;

		public SceneData SceneData => null;

		public AsyncOperationStatus Status => default(AsyncOperationStatus);

		public bool IsDone => false;

		public bool Loading => false;

		public bool Activated => false;

		public bool NeedsActivated => false;

		internal SceneLoadTask(OnLoaded onComplete, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
		}

		internal void LoadSceneWithData(AssetReference sceneDataRef, string key)
		{
		}

		internal void LoadScene(AssetReference sceneRef, string key)
		{
		}

		private void OnDataLoaded(AsyncOperationStatus status, AssetReference item, object data)
		{
		}

		private void OnSceneLoadCompleted(AsyncOperationHandle<SceneInstance> obj)
		{
		}

		public void ActivateScene()
		{
		}

		private void OnActivated(AsyncOperation obj)
		{
		}

		public float PercentComplete()
		{
			return 0f;
		}
	}
}
