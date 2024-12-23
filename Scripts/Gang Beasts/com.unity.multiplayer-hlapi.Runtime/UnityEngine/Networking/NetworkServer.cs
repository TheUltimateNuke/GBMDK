using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine.Networking.Match;
using UnityEngine.Networking.NetworkSystem;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public sealed class NetworkServer
	{
		private class ServerSimpleWrapper : NetworkServerSimple
		{
			private NetworkServer m_Server;

			public ServerSimpleWrapper(NetworkServer server)
			{
			}

			public override void OnConnectError(int connectionId, byte error)
			{
			}

			public override void OnDataError(NetworkConnection conn, byte error)
			{
			}

			public override void OnDisconnectError(NetworkConnection conn, byte error)
			{
			}

			public override void OnError(int connectionId, byte error)
			{
			}

			public override void OnConnected(NetworkConnection conn)
			{
			}

			public override void OnDisconnected(NetworkConnection conn)
			{
			}

			public override void OnData(NetworkConnection conn, int receivedSize, int channelId)
			{
			}
		}

		private static bool s_Active;

		private static NetworkServer s_Instance;

		private static object s_Sync;

		private static bool m_DontListen;

		private bool m_LocalClientActive;

		private List<NetworkConnection> m_LocalConnectionsFakeList;

		private ULocalConnectionToClient m_LocalConnection;

		private NetworkScene m_NetworkScene;

		private HashSet<int> m_ExternalConnections;

		private ServerSimpleWrapper m_SimpleServerSimple;

		private float m_MaxDelay;

		private HashSet<NetworkInstanceId> m_RemoveList;

		private int m_RemoveListCount;

		private const int k_RemoveListInterval = 100;

		internal static ushort maxPacketSize;

		private static RemovePlayerMessage s_RemovePlayerMessage;

		public static List<NetworkConnection> localConnections => null;

		public static int listenPort => 0;

		public static int serverHostId => 0;

		public static ReadOnlyCollection<NetworkConnection> connections => null;

		public static Dictionary<short, NetworkMessageDelegate> handlers => null;

		public static HostTopology hostTopology => null;

		public static Dictionary<NetworkInstanceId, NetworkIdentity> objects => null;

		[Obsolete("Moved to NetworkMigrationManager")]
		public static bool sendPeerInfo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool dontListen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool useWebSockets
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal static NetworkServer instance => null;

		public static bool active => false;

		public static bool localClientActive => false;

		public static int numChannels => 0;

		public static float maxDelay
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static Type networkConnectionClass => null;

		public static void SetNetworkConnectionClass<T>() where T : NetworkConnection
		{
		}

		private NetworkServer()
		{
		}

		public static bool Configure(ConnectionConfig config, int maxConnections)
		{
			return false;
		}

		public static bool Configure(HostTopology topology)
		{
			return false;
		}

		public static void Reset()
		{
		}

		public static void Shutdown()
		{
		}

		public static bool Listen(MatchInfo matchInfo, int listenPort)
		{
			return false;
		}

		internal void RegisterMessageHandlers()
		{
		}

		public static void ListenRelay(string relayIp, int relayPort, NetworkID netGuid, SourceID sourceId, NodeID nodeId)
		{
		}

		private void InternalListenRelay(string relayIp, int relayPort, NetworkID netGuid, SourceID sourceId, NodeID nodeId)
		{
		}

		public static bool Listen(int serverPort)
		{
			return false;
		}

		public static bool Listen(string ipAddress, int serverPort)
		{
			return false;
		}

		internal bool InternalListen(string ipAddress, int serverPort)
		{
			return false;
		}

		public static NetworkClient BecomeHost(NetworkClient oldClient, int port, MatchInfo matchInfo, int oldConnectionId, PeerInfoMessage[] peers)
		{
			return null;
		}

		internal NetworkClient BecomeHostInternal(NetworkClient oldClient, int port, MatchInfo matchInfo, int oldConnectionId, PeerInfoMessage[] peers)
		{
			return null;
		}

		private void InternalSetMaxDelay(float seconds)
		{
		}

		internal int AddLocalClient(LocalClient localClient)
		{
			return 0;
		}

		internal void RemoveLocalClient(NetworkConnection localClientConnection)
		{
		}

		internal void SetLocalObjectOnServer(NetworkInstanceId netId, GameObject obj)
		{
		}

		internal void ActivateLocalClientScene()
		{
		}

		public static bool SendToAll(short msgType, MessageBase msg)
		{
			return false;
		}

		private static bool SendToObservers(GameObject contextObj, short msgType, MessageBase msg)
		{
			return false;
		}

		public static bool SendToReady(GameObject contextObj, short msgType, MessageBase msg)
		{
			return false;
		}

		public static void SendWriterToReady(GameObject contextObj, NetworkWriter writer, int channelId)
		{
		}

		public static void SendBytesToReady(GameObject contextObj, byte[] buffer, int numBytes, int channelId)
		{
		}

		public static void SendBytesToPlayer(GameObject player, byte[] buffer, int numBytes, int channelId)
		{
		}

		public static bool SendUnreliableToAll(short msgType, MessageBase msg)
		{
			return false;
		}

		public static bool SendUnreliableToReady(GameObject contextObj, short msgType, MessageBase msg)
		{
			return false;
		}

		public static bool SendByChannelToAll(short msgType, MessageBase msg, int channelId)
		{
			return false;
		}

		public static bool SendByChannelToReady(GameObject contextObj, short msgType, MessageBase msg, int channelId)
		{
			return false;
		}

		public static void DisconnectAll()
		{
		}

		internal void InternalDisconnectAll()
		{
		}

		internal static void Update()
		{
		}

		private void UpdateServerObjects()
		{
		}

		private void CheckForNullObjects()
		{
		}

		internal void InternalUpdate()
		{
		}

		private void OnConnected(NetworkConnection conn)
		{
		}

		private void OnDisconnected(NetworkConnection conn)
		{
		}

		private void OnData(NetworkConnection conn, int receivedSize, int channelId)
		{
		}

		private void GenerateConnectError(int error)
		{
		}

		private void GenerateDataError(NetworkConnection conn, int error)
		{
		}

		private void GenerateDisconnectError(NetworkConnection conn, int error)
		{
		}

		private void GenerateError(NetworkConnection conn, int error)
		{
		}

		public static void RegisterHandler(short msgType, NetworkMessageDelegate handler)
		{
		}

		public static void UnregisterHandler(short msgType)
		{
		}

		public static void ClearHandlers()
		{
		}

		public static void ClearSpawners()
		{
		}

		public static void GetStatsOut(out int numMsgs, out int numBufferedMsgs, out int numBytes, out int lastBufferedPerSecond)
		{
			numMsgs = default(int);
			numBufferedMsgs = default(int);
			numBytes = default(int);
			lastBufferedPerSecond = default(int);
		}

		public static void GetStatsIn(out int numMsgs, out int numBytes)
		{
			numMsgs = default(int);
			numBytes = default(int);
		}

		public static void SendToClientOfPlayer(GameObject player, short msgType, MessageBase msg)
		{
		}

		public static void SendToClient(int connectionId, short msgType, MessageBase msg)
		{
		}

		public static bool ReplacePlayerForConnection(NetworkConnection conn, GameObject player, short playerControllerId, NetworkHash128 assetId)
		{
			return false;
		}

		public static bool ReplacePlayerForConnection(NetworkConnection conn, GameObject player, short playerControllerId)
		{
			return false;
		}

		public static bool AddPlayerForConnection(NetworkConnection conn, GameObject player, short playerControllerId, NetworkHash128 assetId)
		{
			return false;
		}

		public static bool AddPlayerForConnection(NetworkConnection conn, GameObject player, short playerControllerId)
		{
			return false;
		}

		internal bool InternalAddPlayerForConnection(NetworkConnection conn, GameObject playerGameObject, short playerControllerId)
		{
			return false;
		}

		private static bool CheckPlayerControllerIdForConnection(NetworkConnection conn, short playerControllerId)
		{
			return false;
		}

		private bool SetupLocalPlayerForConnection(NetworkConnection conn, NetworkIdentity uv, PlayerController newPlayerController)
		{
			return false;
		}

		private static void FinishPlayerForConnection(NetworkConnection conn, NetworkIdentity uv, GameObject playerGameObject)
		{
		}

		internal bool InternalReplacePlayerForConnection(NetworkConnection conn, GameObject playerGameObject, short playerControllerId)
		{
			return false;
		}

		private static bool GetNetworkIdentity(GameObject go, out NetworkIdentity view)
		{
			view = null;
			return false;
		}

		public static void SetClientReady(NetworkConnection conn)
		{
		}

		internal void SetClientReadyInternal(NetworkConnection conn)
		{
		}

		internal static void ShowForConnection(NetworkIdentity uv, NetworkConnection conn)
		{
		}

		internal static void HideForConnection(NetworkIdentity uv, NetworkConnection conn)
		{
		}

		public static void SetAllClientsNotReady()
		{
		}

		public static void SetClientNotReady(NetworkConnection conn)
		{
		}

		internal void InternalSetClientNotReady(NetworkConnection conn)
		{
		}

		private static void OnClientReadyMessage(NetworkMessage netMsg)
		{
		}

		private static void OnRemovePlayerMessage(NetworkMessage netMsg)
		{
		}

		private static void OnCommandMessage(NetworkMessage netMsg)
		{
		}

		internal void SpawnObject(GameObject obj)
		{
		}

		internal void SendSpawnMessage(NetworkIdentity uv, NetworkConnection conn)
		{
		}

		public static void DestroyPlayersForConnection(NetworkConnection conn)
		{
		}

		private static void UnSpawnObject(GameObject obj)
		{
		}

		private static void UnSpawnObject(NetworkIdentity uv)
		{
		}

		private static void DestroyObject(GameObject obj)
		{
		}

		private static void DestroyObject(NetworkIdentity uv, bool destroyServerObject)
		{
		}

		public static void ClearLocalObjects()
		{
		}

		public static void Spawn(GameObject obj)
		{
		}

		private static bool CheckForPrefab(GameObject obj)
		{
			return false;
		}

		private static bool VerifyCanSpawn(GameObject obj)
		{
			return false;
		}

		public static bool SpawnWithClientAuthority(GameObject obj, GameObject player)
		{
			return false;
		}

		public static bool SpawnWithClientAuthority(GameObject obj, NetworkConnection conn)
		{
			return false;
		}

		public static bool SpawnWithClientAuthority(GameObject obj, NetworkHash128 assetId, NetworkConnection conn)
		{
			return false;
		}

		public static void Spawn(GameObject obj, NetworkHash128 assetId)
		{
		}

		public static void Destroy(GameObject obj)
		{
		}

		public static void UnSpawn(GameObject obj)
		{
		}

		internal bool InvokeBytes(ULocalConnectionToServer conn, byte[] buffer, int numBytes, int channelId)
		{
			return false;
		}

		internal bool InvokeHandlerOnServer(ULocalConnectionToServer conn, short msgType, MessageBase msg, int channelId)
		{
			return false;
		}

		public static GameObject FindLocalObject(NetworkInstanceId netId)
		{
			return null;
		}

		public static Dictionary<short, NetworkConnection.PacketStat> GetConnectionStats()
		{
			return null;
		}

		public static void ResetConnectionStats()
		{
		}

		public static bool AddExternalConnection(NetworkConnection conn)
		{
			return false;
		}

		private bool AddExternalConnectionInternal(NetworkConnection conn)
		{
			return false;
		}

		public static void RemoveExternalConnection(int connectionId)
		{
		}

		private bool RemoveExternalConnectionInternal(int connectionId)
		{
			return false;
		}

		private static bool ValidateSceneObject(NetworkIdentity netId)
		{
			return false;
		}

		public static bool SpawnObjects()
		{
			return false;
		}

		private static void SendCrc(NetworkConnection targetConnection)
		{
		}

		[Obsolete("moved to NetworkMigrationManager")]
		public void SendNetworkInfo(NetworkConnection targetConnection)
		{
		}
	}
}
