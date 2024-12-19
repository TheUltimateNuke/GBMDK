using System;
using System.Net;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	internal class DefaultNetworkTransport : INetworkTransport
	{
		public bool IsStarted => false;

		public int AddHost(HostTopology topology, int port, string ip)
		{
			return 0;
		}

		public int AddHostWithSimulator(HostTopology topology, int minTimeout, int maxTimeout, int port)
		{
			return 0;
		}

		public int AddWebsocketHost(HostTopology topology, int port, string ip)
		{
			return 0;
		}

		public int Connect(int hostId, string address, int port, int specialConnectionId, out byte error)
		{
			error = default(byte);
			return 0;
		}

		public void ConnectAsNetworkHost(int hostId, string address, int port, NetworkID network, SourceID source, NodeID node, out byte error)
		{
			error = default(byte);
		}

		public int ConnectEndPoint(int hostId, EndPoint endPoint, int specialConnectionId, out byte error)
		{
			error = default(byte);
			return 0;
		}

		public int ConnectToNetworkPeer(int hostId, string address, int port, int specialConnectionId, int relaySlotId, NetworkID network, SourceID source, NodeID node, out byte error)
		{
			error = default(byte);
			return 0;
		}

		public int ConnectWithSimulator(int hostId, string address, int port, int specialConnectionId, out byte error, ConnectionSimulatorConfig conf)
		{
			error = default(byte);
			return 0;
		}

		public bool Disconnect(int hostId, int connectionId, out byte error)
		{
			error = default(byte);
			return false;
		}

		public bool DoesEndPointUsePlatformProtocols(EndPoint endPoint)
		{
			return false;
		}

		public void GetBroadcastConnectionInfo(int hostId, out string address, out int port, out byte error)
		{
			address = null;
			port = default(int);
			error = default(byte);
		}

		public void GetBroadcastConnectionMessage(int hostId, byte[] buffer, int bufferSize, out int receivedSize, out byte error)
		{
			receivedSize = default(int);
			error = default(byte);
		}

		public void GetConnectionInfo(int hostId, int connectionId, out string address, out int port, out NetworkID network, out NodeID dstNode, out byte error)
		{
			address = null;
			port = default(int);
			network = default(NetworkID);
			dstNode = default(NodeID);
			error = default(byte);
		}

		public int GetCurrentRTT(int hostId, int connectionId, out byte error)
		{
			error = default(byte);
			return 0;
		}

		public void Init()
		{
		}

		public void Init(GlobalConfig config)
		{
		}

		public NetworkEventType Receive(out int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error)
		{
			hostId = default(int);
			connectionId = default(int);
			channelId = default(int);
			receivedSize = default(int);
			error = default(byte);
			return default(NetworkEventType);
		}

		public NetworkEventType ReceiveFromHost(int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error)
		{
			connectionId = default(int);
			channelId = default(int);
			receivedSize = default(int);
			error = default(byte);
			return default(NetworkEventType);
		}

		public NetworkEventType ReceiveRelayEventFromHost(int hostId, out byte error)
		{
			error = default(byte);
			return default(NetworkEventType);
		}

		public bool RemoveHost(int hostId)
		{
			return false;
		}

		public bool Send(int hostId, int connectionId, int channelId, byte[] buffer, int size, out byte error)
		{
			error = default(byte);
			return false;
		}

		public void SetBroadcastCredentials(int hostId, int key, int version, int subversion, out byte error)
		{
			error = default(byte);
		}

		public void SetPacketStat(int direction, int packetStatId, int numMsgs, int numBytes)
		{
		}

		public void Shutdown()
		{
		}

		public bool StartBroadcastDiscovery(int hostId, int broadcastPort, int key, int version, int subversion, byte[] buffer, int size, int timeout, out byte error)
		{
			error = default(byte);
			return false;
		}

		public void StopBroadcastDiscovery()
		{
		}
	}
}
