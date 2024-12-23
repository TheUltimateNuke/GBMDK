using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class NetworkServerSimple
	{
		private bool m_Initialized;

		private int m_ListenPort;

		private int m_ServerHostId;

		private int m_RelaySlotId;

		private bool m_UseWebSockets;

		private byte[] m_MsgBuffer;

		private NetworkReader m_MsgReader;

		private Type m_NetworkConnectionClass;

		private HostTopology m_HostTopology;

		private List<NetworkConnection> m_Connections;

		private ReadOnlyCollection<NetworkConnection> m_ConnectionsReadOnly;

		private NetworkMessageHandlers m_MessageHandlers;

		public int listenPort
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int serverHostId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public HostTopology hostTopology => null;

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

		public ReadOnlyCollection<NetworkConnection> connections => null;

		public Dictionary<short, NetworkMessageDelegate> handlers => null;

		public byte[] messageBuffer => null;

		public NetworkReader messageReader => null;

		public Type networkConnectionClass => null;

		public void SetNetworkConnectionClass<T>() where T : NetworkConnection
		{
		}

		public virtual void Initialize()
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

		public bool Listen(string ipAddress, int serverListenPort)
		{
			return false;
		}

		public bool Listen(int serverListenPort)
		{
			return false;
		}

		public bool Listen(int serverListenPort, HostTopology topology)
		{
			return false;
		}

		public void ListenRelay(string relayIp, int relayPort, NetworkID netGuid, SourceID sourceId, NodeID nodeId)
		{
		}

		public void Stop()
		{
		}

		internal void RegisterHandlerSafe(short msgType, NetworkMessageDelegate handler)
		{
		}

		public void RegisterHandler(short msgType, NetworkMessageDelegate handler)
		{
		}

		public void UnregisterHandler(short msgType)
		{
		}

		public void ClearHandlers()
		{
		}

		public void UpdateConnections()
		{
		}

		public void Update()
		{
		}

		public NetworkConnection FindConnection(int connectionId)
		{
			return null;
		}

		public bool SetConnectionAtIndex(NetworkConnection conn)
		{
			return false;
		}

		public bool RemoveConnectionAtIndex(int connectionId)
		{
			return false;
		}

		private void HandleConnect(int connectionId, byte error)
		{
		}

		private void HandleDisconnect(int connectionId, byte error)
		{
		}

		private void HandleData(int connectionId, int channelId, int receivedSize, byte error)
		{
		}

		public void SendBytesTo(int connectionId, byte[] bytes, int numBytes, int channelId)
		{
		}

		public void SendWriterTo(int connectionId, NetworkWriter writer, int channelId)
		{
		}

		public void Disconnect(int connectionId)
		{
		}

		public void DisconnectAllConnections()
		{
		}

		public virtual void OnConnectError(int connectionId, byte error)
		{
		}

		public virtual void OnDataError(NetworkConnection conn, byte error)
		{
		}

		public virtual void OnDisconnectError(NetworkConnection conn, byte error)
		{
		}

		public virtual void OnError(int connectionId, byte error)
		{
		}

		public virtual void OnConnected(NetworkConnection conn)
		{
		}

		public virtual void OnDisconnected(NetworkConnection conn)
		{
		}

		public virtual void OnData(NetworkConnection conn, int receivedSize, int channelId)
		{
		}
	}
}
