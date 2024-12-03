using System;
using System.Collections.Generic;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class NetworkConnection : IDisposable
	{
		public class PacketStat
		{
			public short msgType;

			public int count;

			public int bytes;

			public PacketStat()
			{
			}

			public PacketStat(PacketStat s)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		private ChannelBuffer[] m_Channels;

		private List<PlayerController> m_PlayerControllers;

		private NetworkMessage m_NetMsg;

		private HashSet<NetworkIdentity> m_VisList;

		private NetworkWriter m_Writer;

		private Dictionary<short, NetworkMessageDelegate> m_MessageHandlersDict;

		private NetworkMessageHandlers m_MessageHandlers;

		private HashSet<NetworkInstanceId> m_ClientOwnedObjects;

		private NetworkMessage m_MessageInfo;

		private const int k_MaxMessageLogSize = 150;

		private NetworkError error;

		public int hostId;

		public int connectionId;

		public bool isReady;

		public string address;

		public float lastMessageTime;

		public bool logNetworkMessages;

		private Dictionary<short, PacketStat> m_PacketStats;

		private bool m_Disposed;

		internal HashSet<NetworkIdentity> visList => null;

		public List<PlayerController> playerControllers => null;

		public HashSet<NetworkInstanceId> clientOwnedObjects => null;

		public bool isConnected => false;

		public NetworkError lastError
		{
			get
			{
				return default(NetworkError);
			}
			internal set
			{
			}
		}

		internal Dictionary<short, PacketStat> packetStats => null;

		public virtual void Initialize(string networkAddress, int networkHostId, int networkConnectionId, HostTopology hostTopology)
		{
		}

		~NetworkConnection()
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		private static bool IsSequencedQoS(QosType qos)
		{
			return false;
		}

		private static bool IsReliableQoS(QosType qos)
		{
			return false;
		}

		public bool SetChannelOption(int channelId, ChannelOption option, int value)
		{
			return false;
		}

		public void Disconnect()
		{
		}

		internal void SetHandlers(NetworkMessageHandlers handlers)
		{
		}

		public bool CheckHandler(short msgType)
		{
			return false;
		}

		public bool InvokeHandlerNoData(short msgType)
		{
			return false;
		}

		public bool InvokeHandler(short msgType, NetworkReader reader, int channelId)
		{
			return false;
		}

		public bool InvokeHandler(NetworkMessage netMsg)
		{
			return false;
		}

		internal void HandleFragment(NetworkReader reader, int channelId)
		{
		}

		public void RegisterHandler(short msgType, NetworkMessageDelegate handler)
		{
		}

		public void UnregisterHandler(short msgType)
		{
		}

		internal void SetPlayerController(PlayerController player)
		{
		}

		internal void RemovePlayerController(short playerControllerId)
		{
		}

		internal bool GetPlayerController(short playerControllerId, out PlayerController playerController)
		{
			playerController = null;
			return false;
		}

		public void FlushChannels()
		{
		}

		public void SetMaxDelay(float seconds)
		{
		}

		public virtual bool Send(short msgType, MessageBase msg)
		{
			return false;
		}

		public virtual bool SendUnreliable(short msgType, MessageBase msg)
		{
			return false;
		}

		public virtual bool SendByChannel(short msgType, MessageBase msg, int channelId)
		{
			return false;
		}

		public virtual bool SendBytes(byte[] bytes, int numBytes, int channelId)
		{
			return false;
		}

		public virtual bool SendWriter(NetworkWriter writer, int channelId)
		{
			return false;
		}

		private void LogSend(byte[] bytes)
		{
		}

		private bool CheckChannel(int channelId)
		{
			return false;
		}

		public void ResetStats()
		{
		}

		protected void HandleBytes(byte[] buffer, int receivedSize, int channelId)
		{
		}

		protected void HandleReader(NetworkReader reader, int receivedSize, int channelId)
		{
		}

		public virtual void GetStatsOut(out int numMsgs, out int numBufferedMsgs, out int numBytes, out int lastBufferedPerSecond)
		{
			numMsgs = default(int);
			numBufferedMsgs = default(int);
			numBytes = default(int);
			lastBufferedPerSecond = default(int);
		}

		public virtual void GetStatsIn(out int numMsgs, out int numBytes)
		{
			numMsgs = default(int);
			numBytes = default(int);
		}

		public override string ToString()
		{
			return null;
		}

		internal void AddToVisList(NetworkIdentity uv)
		{
		}

		internal void RemoveFromVisList(NetworkIdentity uv, bool isDestroyed)
		{
		}

		internal void RemoveObservers()
		{
		}

		public virtual void TransportReceive(byte[] bytes, int numBytes, int channelId)
		{
		}

		[Obsolete("TransportRecieve has been deprecated. Use TransportReceive instead.", false)]
		public virtual void TransportRecieve(byte[] bytes, int numBytes, int channelId)
		{
		}

		public virtual bool TransportSend(byte[] bytes, int numBytes, int channelId, out byte error)
		{
			error = default(byte);
			return false;
		}

		internal void AddOwnedObject(NetworkIdentity obj)
		{
		}

		internal void RemoveOwnedObject(NetworkIdentity obj)
		{
		}

		internal static void OnFragment(NetworkMessage netMsg)
		{
		}
	}
}
