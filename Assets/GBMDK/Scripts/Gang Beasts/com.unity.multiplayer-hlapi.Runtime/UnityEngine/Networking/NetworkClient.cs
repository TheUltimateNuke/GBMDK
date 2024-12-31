using System;
using System.Collections.Generic;
using System.Net;
using UnityEngine.Networking.Match;
using UnityEngine.Networking.NetworkSystem;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class NetworkClient
	{
		protected enum ConnectState
		{
			None = 0,
			Resolving = 1,
			Resolved = 2,
			Connecting = 3,
			Connected = 4,
			Disconnected = 5,
			Failed = 6
		}

		private Type m_NetworkConnectionClass;

		private const int k_MaxEventsPerFrame = 500;

		private static List<NetworkClient> s_Clients;

		private static bool s_IsActive;

		private HostTopology m_HostTopology;

		private int m_HostPort;

		private bool m_UseSimulator;

		private int m_SimulatedLatency;

		private float m_PacketLoss;

		private string m_ServerIp;

		private int m_ServerPort;

		private int m_ClientId;

		private int m_ClientConnectionId;

		private int m_StatResetTime;

		private EndPoint m_RemoteEndPoint;

		private static CRCMessage s_CRCMessage;

		private NetworkMessageHandlers m_MessageHandlers;

		protected NetworkConnection m_Connection;

		private byte[] m_MsgBuffer;

		private NetworkReader m_MsgReader;

		protected ConnectState m_AsyncConnect;

		private string m_RequestedServerHost;

		public static List<NetworkClient> allClients => null;

		public static bool active => false;

		public string serverIp => null;

		public int serverPort => 0;

		public NetworkConnection connection => null;

		[Obsolete("Moved to NetworkMigrationManager.")]
		public PeerInfoMessage[] peers => null;

		internal int hostId => 0;

		public Dictionary<short, NetworkMessageDelegate> handlers => null;

		public int numChannels => 0;

		public HostTopology hostTopology => null;

		public int hostPort
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool isConnected => false;

		public Type networkConnectionClass => null;

		internal void SetHandlers(NetworkConnection conn)
		{
		}

		public void SetNetworkConnectionClass<T>() where T : NetworkConnection
		{
		}

		public NetworkClient()
		{
		}

		public NetworkClient(NetworkConnection conn)
		{
		}

		public bool Configure(ConnectionConfig config, int maxConnections)
		{
			return false;
		}

		public bool Configure(HostTopology topology)
		{
			return false;
		}

		public void Connect(MatchInfo matchInfo)
		{
		}

		public bool ReconnectToNewHost(string serverIp, int serverPort)
		{
			return false;
		}

		public bool ReconnectToNewHost(EndPoint secureTunnelEndPoint)
		{
			return false;
		}

		public void ConnectWithSimulator(string serverIp, int serverPort, int latency, float packetLoss)
		{
		}

		private static bool IsValidIpV6(string address)
		{
			return false;
		}

		public void Connect(string serverIp, int serverPort)
		{
		}

		public void Connect(EndPoint secureTunnelEndPoint)
		{
		}

		private void PrepareForConnect()
		{
		}

		private void PrepareForConnect(bool usePlatformSpecificProtocols)
		{
		}

		internal static void GetHostAddressesCallback(IAsyncResult ar)
		{
		}

		internal void ContinueConnect()
		{
		}

		private void ConnectWithRelay(MatchInfo info)
		{
		}

		public virtual void Disconnect()
		{
		}

		public bool Send(short msgType, MessageBase msg)
		{
			return false;
		}

		public bool SendWriter(NetworkWriter writer, int channelId)
		{
			return false;
		}

		public bool SendBytes(byte[] data, int numBytes, int channelId)
		{
			return false;
		}

		public bool SendUnreliable(short msgType, MessageBase msg)
		{
			return false;
		}

		public bool SendByChannel(short msgType, MessageBase msg, int channelId)
		{
			return false;
		}

		public void SetMaxDelay(float seconds)
		{
		}

		public void Shutdown()
		{
		}

		internal virtual void Update()
		{
		}

		private void GenerateConnectError(int error)
		{
		}

		private void GenerateDataError(int error)
		{
		}

		private void GenerateDisconnectError(int error)
		{
		}

		private void GenerateError(int error)
		{
		}

		public void GetStatsOut(out int numMsgs, out int numBufferedMsgs, out int numBytes, out int lastBufferedPerSecond)
		{
			numMsgs = default(int);
			numBufferedMsgs = default(int);
			numBytes = default(int);
			lastBufferedPerSecond = default(int);
		}

		public void GetStatsIn(out int numMsgs, out int numBytes)
		{
			numMsgs = default(int);
			numBytes = default(int);
		}

		public Dictionary<short, NetworkConnection.PacketStat> GetConnectionStats()
		{
			return null;
		}

		public void ResetConnectionStats()
		{
		}

		public int GetRTT()
		{
			return 0;
		}

		internal void RegisterSystemHandlers(bool localClient)
		{
		}

		private void OnCRC(NetworkMessage netMsg)
		{
		}

		public void RegisterHandler(short msgType, NetworkMessageDelegate handler)
		{
		}

		public void RegisterHandlerSafe(short msgType, NetworkMessageDelegate handler)
		{
		}

		public void UnregisterHandler(short msgType)
		{
		}

		public static Dictionary<short, NetworkConnection.PacketStat> GetTotalConnectionStats()
		{
			return null;
		}

		internal static void AddClient(NetworkClient client)
		{
		}

		internal static bool RemoveClient(NetworkClient client)
		{
			return false;
		}

		internal static void UpdateClients()
		{
		}

		public static void ShutdownAll()
		{
		}

		internal static void SetActive(bool state)
		{
		}
	}
}
