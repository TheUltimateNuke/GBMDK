using System.Collections;
using System.Collections.Generic;
using GB.Data.Loading;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GB.Core
{
	public static class Resources
	{
		public delegate void OnLoaded(AsyncOperationStatus status, AssetReference item, object data);

		public abstract class LoadItem : ICompleteTracker
		{
			public string Key;

			private int _references;

			public AssetReference Reference;

			public OnLoaded itemLoaded;

			public object Result;

			protected AsyncOperationStatus _finishedLoading;

			protected AsyncOperationHandle _loadHandle;

			public int References
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public AsyncOperationStatus Status => default(AsyncOperationStatus);

			public bool IsDone => false;

			internal LoadItem(AssetReference reference)
			{
			}

			internal LoadItem()
			{
			}

			protected abstract AsyncOperationHandle Load();

			protected virtual void Unload()
			{
			}

			protected virtual void OnLoadedFinished(AsyncOperationHandle obj)
			{
			}

			public abstract float PercentComplete();
		}

		private class LoadObject<T> : LoadItem
		{
			internal LoadObject(AssetReference reference)
				: base(null)
			{
			}

			protected override AsyncOperationHandle Load()
			{
				return default(AsyncOperationHandle);
			}

			public override float PercentComplete()
			{
				return 0f;
			}
		}

		private class LoadLoadedItem : LoadItem
		{
			internal LoadLoadedItem(AssetReference reference)
				: base(null)
			{
			}

			protected override AsyncOperationHandle Load()
			{
				return default(AsyncOperationHandle);
			}

			protected override void OnLoadedFinished(AsyncOperationHandle obj)
			{
			}

			protected override void Unload()
			{
			}

			public override float PercentComplete()
			{
				return 0f;
			}
		}

		private static int _loading;

		private static List<LoadItem> _assetList;

		public static IReadOnlyList<LoadItem> DebugRawAssets => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static object Get(string key)
		{
			return null;
		}

		public static AssetReference GetRef(string key)
		{
			return null;
		}

		public static IDataCache GetCache(string key)
		{
			return null;
		}

		public static ICompleteTracker Load<T>(AssetReference reference, string key, out object data, OnLoaded onLoaded = null)
		{
			data = null;
			return null;
		}

		public static ICompleteTracker LoadLoadedAsset(AssetReference reference, string key, out object data, OnLoaded onLoaded = null)
		{
			data = null;
			return null;
		}

		public static ICompleteTracker LoadLoadedAsset(string key, out object data, OnLoaded onLoaded = null)
		{
			data = null;
			return null;
		}

		public static ICompleteTracker Load<T>(string key, out object data, OnLoaded onLoaded = null)
		{
			data = null;
			return null;
		}

		private static void OnItemLoaded(AsyncOperationStatus status, AssetReference item, object data)
		{
		}

		public static float LoadPercent()
		{
			return 0f;
		}

		public static void Release(AssetReference reference)
		{
		}

		public static void Release(string key)
		{
		}

		public static bool Loading()
		{
			return false;
		}

		private static IEnumerator WaitForLoad()
		{
			return null;
		}

		public static void Purge()
		{
		}
	}
}
