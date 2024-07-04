using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GB.Data.Loading
{
	[Serializable]
	public class ResourceObject
	{
		[SerializeField]
		private string Key;

		[SerializeField]
		private AssetReference _assetsCache;

		[SerializeField]
		private ResourceLoadType _loadType;

		[NonSerialized]
		private object _data;

		private Action OnLoadedFinished;

		public AssetReference AssetsCache => null;

		public AsyncOperationStatus Status { get; private set; }

		public object Data => null;

		public bool Loaded => false;

		private void OnLoaded(AsyncOperationStatus status, AssetReference item, object data)
		{
		}

		public void Release()
		{
		}

		public void LoadData(Action OnComplete = null)
		{
		}

		public void Unload()
		{
		}
	}
}
