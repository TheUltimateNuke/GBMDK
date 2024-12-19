using System;
using System.Collections.Generic;
using UnityEngine.Networking.NetworkSystem;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class ClientScene
	{
		private struct PendingOwner
		{
			public NetworkInstanceId netId;

			public short playerControllerId;
		}

		private static List<PlayerController> s_LocalPlayers;

		private static NetworkConnection s_ReadyConnection;

		private static Dictionary<NetworkSceneId, NetworkIdentity> s_SpawnableObjects;

		private static bool s_IsReady;

		private static bool s_IsSpawnFinished;

		private static NetworkScene s_NetworkScene;

		private static ObjectSpawnSceneMessage s_ObjectSpawnSceneMessage;

		private static ObjectSpawnFinishedMessage s_ObjectSpawnFinishedMessage;

		private static ObjectDestroyMessage s_ObjectDestroyMessage;

		private static ObjectSpawnMessage s_ObjectSpawnMessage;

		private static OwnerMessage s_OwnerMessage;

		private static ClientAuthorityMessage s_ClientAuthorityMessage;

		public const int ReconnectIdInvalid = -1;

		public const int ReconnectIdHost = 0;

		private static int s_ReconnectId;

		private static PeerInfoMessage[] s_Peers;

		private static List<PendingOwner> s_PendingOwnerIds;

		public static List<PlayerController> localPlayers => null;

		public static bool ready => false;

		public static NetworkConnection readyConnection => null;

		public static int reconnectId => 0;

		public static Dictionary<NetworkInstanceId, NetworkIdentity> objects => null;

		public static Dictionary<NetworkHash128, GameObject> prefabs => null;

		public static Dictionary<NetworkSceneId, NetworkIdentity> spawnableObjects => null;

		private static bool hasMigrationPending()
		{
			return false;
		}

		public static void SetReconnectId(int newReconnectId, PeerInfoMessage[] peers)
		{
		}

		internal static void SetNotReady()
		{
		}

		internal static void Shutdown()
		{
		}

		internal static bool GetPlayerController(short playerControllerId, out PlayerController player)
		{
			player = null;
			return false;
		}

		internal static void InternalAddPlayer(NetworkIdentity view, short playerControllerId)
		{
		}

		public static bool AddPlayer(short playerControllerId)
		{
			return false;
		}

		public static bool AddPlayer(NetworkConnection readyConn, short playerControllerId)
		{
			return false;
		}

		public static bool AddPlayer(NetworkConnection readyConn, short playerControllerId, MessageBase extraMessage)
		{
			return false;
		}

		public static bool SendReconnectMessage(MessageBase extraMessage)
		{
			return false;
		}

		public static bool RemovePlayer(short playerControllerId)
		{
			return false;
		}

		public static bool Ready(NetworkConnection conn)
		{
			return false;
		}

		public static NetworkClient ConnectLocalServer()
		{
			return null;
		}

		internal static NetworkClient ReconnectLocalServer()
		{
			return null;
		}

		internal static void ClearLocalPlayers()
		{
		}

		internal static void HandleClientDisconnect(NetworkConnection conn)
		{
		}

		internal static void PrepareToSpawnSceneObjects()
		{
		}

		internal static NetworkIdentity SpawnSceneObject(NetworkSceneId sceneId)
		{
			return null;
		}

		internal static void RegisterSystemHandlers(NetworkClient client, bool localClient)
		{
		}

		internal static string GetStringForAssetId(NetworkHash128 assetId)
		{
			return null;
		}

		public static void RegisterPrefab(GameObject prefab, NetworkHash128 newAssetId)
		{
		}

		public static void RegisterPrefab(GameObject prefab)
		{
		}

		public static void RegisterPrefab(GameObject prefab, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler)
		{
		}

		public static void UnregisterPrefab(GameObject prefab)
		{
		}

		public static void RegisterSpawnHandler(NetworkHash128 assetId, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler)
		{
		}

		public static void UnregisterSpawnHandler(NetworkHash128 assetId)
		{
		}

		public static void ClearSpawners()
		{
		}

		public static void DestroyAllClientObjects()
		{
		}

		public static void SetLocalObject(NetworkInstanceId netId, GameObject obj)
		{
		}

		public static GameObject FindLocalObject(NetworkInstanceId netId)
		{
			return null;
		}

		private static void ApplySpawnPayload(NetworkIdentity uv, Vector3 position, byte[] payload, NetworkInstanceId netId, GameObject newGameObject, NetworkMessage netMsg)
		{
		}

		private static void OnObjectSpawn(NetworkMessage netMsg)
		{
		}

		private static void OnObjectSpawnScene(NetworkMessage netMsg)
		{
		}

		private static void OnObjectSpawnFinished(NetworkMessage netMsg)
		{
		}

		private static void OnObjectDestroy(NetworkMessage netMsg)
		{
		}

		private static void OnLocalClientObjectDestroy(NetworkMessage netMsg)
		{
		}

		private static void OnLocalClientObjectHide(NetworkMessage netMsg)
		{
		}

		private static void OnLocalClientObjectSpawn(NetworkMessage netMsg)
		{
		}

		private static void OnLocalClientObjectSpawnScene(NetworkMessage netMsg)
		{
		}

		private static void OnUpdateVarsMessage(NetworkMessage netMsg)
		{
		}

		private static void OnRPCMessage(NetworkMessage netMsg)
		{
		}

		private static void OnSyncEventMessage(NetworkMessage netMsg)
		{
		}

		private static void OnSyncListMessage(NetworkMessage netMsg)
		{
		}

		private static void OnClientAuthority(NetworkMessage netMsg)
		{
		}

		private static void OnOwnerMessage(NetworkMessage netMsg)
		{
		}

		private static void CheckForOwner(NetworkIdentity uv)
		{
		}
	}
}
