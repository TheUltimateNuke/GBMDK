using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GB.Data.Loading
{
	[Serializable]
	public class StringResourceCache : IDataCache, ILoadedAsset, ICompleteTracker
	{
		[SerializeField]
		private string _key;

		private bool _loading;

		[NonSerialized]
		private IDataCache _cache;

		private ICompleteTracker _loadProgress;

		private AsyncOperationStatus _status;

		private Action OnLoadedFinished;

		public string Key
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IDataCache Cache => null;

		public int Count => 0;

		public AsyncOperationStatus Status => default(AsyncOperationStatus);

		public bool IsDone => false;

		public AssetReference this[int index] => null;

		public AssetReference this[string key] => null;

		public bool Loading()
		{
			return false;
		}

		private void OnLoaded(AsyncOperationStatus status, AssetReference item, object data)
		{
		}

		public void Release()
		{
		}

		public T GetData<T>(string key) where T : class
		{
			return null;
		}

		public T GetData<T>(int index) where T : class
		{
			return null;
		}

		public void LoadData(Action OnComplete = null)
		{
		}

		public void Unload()
		{
		}

		public float PercentComplete()
		{
			return 0f;
		}
	}
}
