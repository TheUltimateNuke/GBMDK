using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GB.Data.Loading
{
	public class ResourceLoader : MonoBehaviour
	{
		[SerializeField]
		private ResourceCache _resource;

		public IDataCache Cache => null;

		public AssetReference this[int index] => null;

		public AssetReference this[string key] => null;

		private void Awake()
		{
		}

		private void OnDestroy()
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
	}
}
