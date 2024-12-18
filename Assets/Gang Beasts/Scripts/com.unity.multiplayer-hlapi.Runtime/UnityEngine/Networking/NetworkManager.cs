using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using UnityEngine.Networking.Match;
using UnityEngine.Networking.NetworkSystem;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	[AddComponentMenu("Network/NetworkManager")]
	public class NetworkManager : MonoBehaviour
	{
		[SerializeField]
		private int m_NetworkPort;

		[SerializeField]
		private bool m_ServerBindToIP;

		[SerializeField]
		private string m_ServerBindAddress;

		[SerializeField]
		private string m_NetworkAddress;

		[SerializeField]
		private bool m_DontDestroyOnLoad;

		[SerializeField]
		private bool m_RunInBackground;

		[SerializeField]
		private bool m_ScriptCRCCheck;

		[SerializeField]
		private float m_MaxDelay;

		[SerializeField]
		private LogFilter.FilterLevel m_LogLevel;

		[SerializeField]
		private GameObject m_PlayerPrefab;

		[SerializeField]
		private bool m_AutoCreatePlayer;

		[SerializeField]
		private PlayerSpawnMethod m_PlayerSpawnMethod;

		[SerializeField]
		private string m_OfflineScene;

		[SerializeField]
		private string m_OnlineScene;

		[SerializeField]
		private List<GameObject> m_SpawnPrefabs;

		[SerializeField]
		private bool m_CustomConfig;

		[SerializeField]
		private int m_MaxConnections;

		[SerializeField]
		private ConnectionConfig m_ConnectionConfig;

		[SerializeField]
		private GlobalConfig m_GlobalConfig;

		[SerializeField]
		private List<QosType> m_Channels;

		[SerializeField]
		private bool m_UseWebSockets;

		[SerializeField]
		private bool m_UseSimulator;

		[SerializeField]
		private int m_SimulatedLatency;

		[SerializeField]
		private float m_PacketLossPercentage;

		[SerializeField]
		private int m_MaxBufferedPackets;

		[SerializeField]
		private bool m_AllowFragmentation;

		[SerializeField]
		private string m_MatchHost;

		[SerializeField]
		private int m_MatchPort;

		[SerializeField]
		public string matchName;

		[SerializeField]
		public uint matchSize;

		private NetworkMigrationManager m_MigrationManager;

		private EndPoint m_EndPoint;

		private bool m_ClientLoadedScene;

		private static INetworkTransport s_ActiveTransport;

		public static string networkSceneName;

		public bool isNetworkActive;

		public NetworkClient client;

		private static List<Transform> s_StartPositions;

		private static int s_StartPositionIndex;

		public MatchInfo matchInfo;

		public NetworkMatch matchMaker;

		public List<MatchInfoSnapshot> matches;

		public static NetworkManager singleton;

		private static AddPlayerMessage s_AddPlayerMessage;

		private static RemovePlayerMessage s_RemovePlayerMessage;

		private static ErrorMessage s_ErrorMessage;

		private static ILoadingSystem s_loadSystem;

		private static NetworkConnection s_ClientReadyConnection;

		private static string s_Address;

		public int networkPort
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool serverBindToIP
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string serverBindAddress
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string networkAddress
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool dontDestroyOnLoad
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool runInBackground
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool scriptCRCCheck
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("moved to NetworkMigrationManager")]
		public bool sendPeerInfo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float maxDelay
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public LogFilter.FilterLevel logLevel
		{
			get
			{
				return default(LogFilter.FilterLevel);
			}
			set
			{
			}
		}

		public GameObject playerPrefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool autoCreatePlayer
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public PlayerSpawnMethod playerSpawnMethod
		{
			get
			{
				return default(PlayerSpawnMethod);
			}
			set
			{
			}
		}

		public string offlineScene
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string onlineScene
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<GameObject> spawnPrefabs => null;

		public List<Transform> startPositions => null;

		public bool customConfig
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ConnectionConfig connectionConfig => null;

		public GlobalConfig globalConfig => null;

		public int maxConnections
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<QosType> channels => null;

		public EndPoint secureTunnelEndpoint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool useWebSockets
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool useSimulator
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int simulatedLatency
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float packetLossPercentage
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public string matchHost
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int matchPort
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool clientLoadedScene
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public NetworkMigrationManager migrationManager => null;

		public int numPlayers => 0;

		public static INetworkTransport defaultTransport => null;

		public static INetworkTransport activeTransport
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static ILoadingSystem LoadSystem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static event Action OnNetworkSceneLoaded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected virtual void OnLogSyncedMessage(string value)
		{
		}

		private void Awake()
		{
		}

		private void InitializeSingleton()
		{
		}

		private void OnValidate()
		{
		}

		internal void RegisterServerMessages()
		{
		}

		public void SetupMigrationManager(NetworkMigrationManager man)
		{
		}

		public bool StartServer(ConnectionConfig config, int maxConnections)
		{
			return false;
		}

		public bool StartServer()
		{
			return false;
		}

		public bool StartServer(MatchInfo info)
		{
			return false;
		}

		private bool StartServer(MatchInfo info, ConnectionConfig config, int maxConnections)
		{
			return false;
		}

		internal void RegisterClientMessages(NetworkClient client)
		{
		}

		public void UseExternalClient(NetworkClient externalClient)
		{
		}

		public NetworkClient StartClient(MatchInfo info, ConnectionConfig config, int hostPort)
		{
			return null;
		}

		public NetworkClient StartClient(MatchInfo matchInfo)
		{
			return null;
		}

		public NetworkClient StartClient()
		{
			return null;
		}

		public NetworkClient StartClient(MatchInfo info, ConnectionConfig config)
		{
			return null;
		}

		public virtual NetworkClient StartHost(ConnectionConfig config, int maxConnections)
		{
			return null;
		}

		public virtual NetworkClient StartHost(MatchInfo info)
		{
			return null;
		}

		public virtual NetworkClient StartHost()
		{
			return null;
		}

		private NetworkClient ConnectLocalClient()
		{
			return null;
		}

		public void StopHost()
		{
		}

		public void StopServer()
		{
		}

		public void StopClient()
		{
		}

		public virtual void ServerChangeScene(string newSceneName)
		{
		}

		private void CleanupNetworkIdentities()
		{
		}

		internal void ClientChangeScene(string newSceneName, bool forceReload)
		{
		}

		private void FinishLoadScene()
		{
		}

		internal static void UpdateScene()
		{
		}

		private void OnDestroy()
		{
		}

		public static void RegisterStartPosition(Transform start)
		{
		}

		public static void UnRegisterStartPosition(Transform start)
		{
		}

		public bool IsClientConnected()
		{
			return false;
		}

		public static void Shutdown()
		{
		}

		internal void OnServerConnectInternal(NetworkMessage netMsg)
		{
		}

		internal void OnServerDisconnectInternal(NetworkMessage netMsg)
		{
		}

		internal void OnServerReadyMessageInternal(NetworkMessage netMsg)
		{
		}

		internal void OnServerAddPlayerMessageInternal(NetworkMessage netMsg)
		{
		}

		internal void OnServerRemovePlayerMessageInternal(NetworkMessage netMsg)
		{
		}

		internal void OnServerErrorInternal(NetworkMessage netMsg)
		{
		}

		internal void OnClientConnectInternal(NetworkMessage netMsg)
		{
		}

		internal void OnClientDisconnectInternal(NetworkMessage netMsg)
		{
		}

		internal void OnClientNotReadyMessageInternal(NetworkMessage netMsg)
		{
		}

		internal void OnClientErrorInternal(NetworkMessage netMsg)
		{
		}

		internal void OnClientSceneInternal(NetworkMessage netMsg)
		{
		}

		public virtual void OnServerConnect(NetworkConnection conn)
		{
		}

		public virtual void OnServerDisconnect(NetworkConnection conn)
		{
		}

		public virtual void OnServerReady(NetworkConnection conn)
		{
		}

		public virtual void OnServerAddPlayer(NetworkConnection conn, short playerControllerId, NetworkReader extraMessageReader)
		{
		}

		public virtual void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
		{
		}

		private void OnServerAddPlayerInternal(NetworkConnection conn, short playerControllerId)
		{
		}

		public Transform GetStartPosition()
		{
			return null;
		}

		public virtual void OnServerRemovePlayer(NetworkConnection conn, PlayerController player)
		{
		}

		public virtual void OnServerError(NetworkConnection conn, int errorCode)
		{
		}

		public virtual void OnServerSceneChanged(string sceneName)
		{
		}

		public virtual void OnClientConnect(NetworkConnection conn)
		{
		}

		public virtual void OnClientDisconnect(NetworkConnection conn)
		{
		}

		public virtual void OnClientError(NetworkConnection conn, int errorCode)
		{
		}

		public virtual void OnClientNotReady(NetworkConnection conn)
		{
		}

		public virtual void OnClientSceneChanged(NetworkConnection conn)
		{
		}

		public void StartMatchMaker()
		{
		}

		public void StopMatchMaker()
		{
		}

		public void SetMatchHost(string newHost, int port, bool https)
		{
		}

		public virtual void OnStartHost()
		{
		}

		public virtual void OnStartServer()
		{
		}

		public virtual void OnStartClient(NetworkClient client)
		{
		}

		public virtual void OnStopServer()
		{
		}

		public virtual void OnStopClient()
		{
		}

		public virtual void OnStopHost()
		{
		}

		public virtual void OnMatchCreate(bool success, string extendedInfo, MatchInfo matchInfo)
		{
		}

		public virtual void OnMatchList(bool success, string extendedInfo, List<MatchInfoSnapshot> matchList)
		{
		}

		public virtual void OnMatchJoined(bool success, string extendedInfo, MatchInfo matchInfo)
		{
		}

		public virtual void OnDestroyMatch(bool success, string extendedInfo)
		{
		}

		public virtual void OnDropConnection(bool success, string extendedInfo)
		{
		}

		public virtual void OnSetMatchAttributes(bool success, string extendedInfo)
		{
		}
	}
}
