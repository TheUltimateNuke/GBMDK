using System.Collections.Generic;

namespace UnityEngine.Networking
{
	internal class NetworkScene
	{
		private Dictionary<NetworkInstanceId, NetworkIdentity> m_LocalObjects;

		private static Dictionary<NetworkHash128, GameObject> s_GuidToPrefab;

		private static Dictionary<NetworkHash128, SpawnDelegate> s_SpawnHandlers;

		private static Dictionary<NetworkHash128, UnSpawnDelegate> s_UnspawnHandlers;

		internal Dictionary<NetworkInstanceId, NetworkIdentity> localObjects => null;

		internal static Dictionary<NetworkHash128, GameObject> guidToPrefab => null;

		internal static Dictionary<NetworkHash128, SpawnDelegate> spawnHandlers => null;

		internal static Dictionary<NetworkHash128, UnSpawnDelegate> unspawnHandlers => null;

		internal void Shutdown()
		{
		}

		internal void SetLocalObject(NetworkInstanceId netId, GameObject obj, bool isClient, bool isServer)
		{
		}

		internal GameObject FindLocalObject(NetworkInstanceId netId)
		{
			return null;
		}

		internal bool GetNetworkIdentity(NetworkInstanceId netId, out NetworkIdentity uv)
		{
			uv = null;
			return false;
		}

		internal bool RemoveLocalObject(NetworkInstanceId netId)
		{
			return false;
		}

		internal bool RemoveLocalObjectAndDestroy(NetworkInstanceId netId)
		{
			return false;
		}

		internal void ClearLocalObjects()
		{
		}

		internal static void RegisterPrefab(GameObject prefab, NetworkHash128 newAssetId)
		{
		}

		internal static void RegisterPrefab(GameObject prefab)
		{
		}

		internal static bool GetPrefab(NetworkHash128 assetId, out GameObject prefab)
		{
			prefab = null;
			return false;
		}

		internal static void ClearSpawners()
		{
		}

		public static void UnregisterSpawnHandler(NetworkHash128 assetId)
		{
		}

		internal static void RegisterSpawnHandler(NetworkHash128 assetId, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler)
		{
		}

		internal static void UnregisterPrefab(GameObject prefab)
		{
		}

		internal static void RegisterPrefab(GameObject prefab, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler)
		{
		}

		internal static bool GetSpawnHandler(NetworkHash128 assetId, out SpawnDelegate handler)
		{
			handler = null;
			return false;
		}

		internal static bool InvokeUnSpawnHandler(NetworkHash128 assetId, GameObject obj)
		{
			return false;
		}

		internal void DestroyAllClientObjects()
		{
		}

		internal void DumpAllClientObjects()
		{
		}
	}
}
