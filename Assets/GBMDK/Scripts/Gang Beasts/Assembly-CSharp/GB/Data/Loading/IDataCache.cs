using UnityEngine.AddressableAssets;

namespace GB.Data.Loading
{
	public interface IDataCache
	{
		AssetReference this[string key] { get; }

		AssetReference this[int index] { get; }

		int Count { get; }

		T GetData<T>(string key) where T : class;

		T GetData<T>(int index) where T : class;
	}
}
