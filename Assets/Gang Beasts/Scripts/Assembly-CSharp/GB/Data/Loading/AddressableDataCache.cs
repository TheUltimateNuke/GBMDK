using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GB.Data.Loading
{
	[CreateAssetMenu(fileName = "AddressableDataCache", menuName = "Gang Beasts/Data/Addressable Data Cache", order = 1)]
	public class AddressableDataCache : ScriptableObject, IDataCache, ILoadedAsset, ICompleteTracker
	{
		[Serializable]
		private class AssetData
		{
			public AssetReference Asset;

			public string Key;

			[SerializeField]
			private ResourceLoadType _loadType;

			[NonSerialized]
			public object Cache;

			private bool _loadStarted;

			private AsyncOperationHandle _process;

			private Action<AssetData> _onComplete;

			public bool NeedsLoading => false;

			internal float PercentComplete => 0f;

			public bool StartLoad(Action<AssetData> onComplete)
			{
				return false;
			}

			public void Unload()
			{
			}

			private void Completed(AsyncOperationHandle obj)
			{
			}
		}

		[SerializeField]
		private List<AssetData> _assets;

		private float _loadTotal;

		private List<AssetData> _loading;

		private bool _unload;

		private bool _unloaded;

		private Action _onCompleteLoading;

		public int Count => 0;

		public AssetReference this[string key] => null;

		public AssetReference this[int index] => null;

		public bool IsDone => false;

		public AsyncOperationStatus Status => default(AsyncOperationStatus);

		public T GetData<T>(string key) where T : class
		{
			return null;
		}

		public T GetData<T>(int index) where T : class
		{
			return null;
		}

		public float PercentComplete()
		{
			return 0f;
		}

		public bool Loading()
		{
			return false;
		}

		public void Unload()
		{
		}

		public void LoadData(Action OnComplete = null)
		{
		}

		private void LoadCompleteMark(AssetData obj)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
