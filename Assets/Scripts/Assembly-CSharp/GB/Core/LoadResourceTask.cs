using System.Collections;
using GB.Data.Loading;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GB.Core
{
	public class LoadResourceTask<T> : IEnumerator, ICompleteTracker
	{
		private bool _started;

		private T _data;

		private ICompleteTracker _loadProgress;

		private AsyncOperationStatus _status;

		private AssetReference _reference;

		private string _key;

		public T Result => default(T);

		public AsyncOperationStatus Status => default(AsyncOperationStatus);

		public AssetReference AssetRef => null;

		public string Key => null;

		public object Current => null;

		public bool IsDone => false;

		public LoadResourceTask(AssetReference reference, string key = null, bool startNow = true)
		{
		}

		public LoadResourceTask(string key, bool startNow = true)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		private void Start()
		{
		}

		private void OnLoaded(AsyncOperationStatus status, AssetReference item, object data)
		{
		}

		public float PercentComplete()
		{
			return 0f;
		}
	}
}
