using System.Collections.Generic;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.Online.Connections
{
	public class NetTransporter
	{
		protected readonly ConnectionCarrier _connections;

		protected bool _running;

		private readonly List<INetReader> _readers;

		private readonly List<PlatformID> _activePlatforms;

		public int this[UserInfo i] => 0;

		public UserInfo this[int i] => default(UserInfo);

		public int TotalConnections => 0;

		public int GetConnectionID(int i)
		{
			return 0;
		}

		public ConnectionStatus GetConnectionStatus(int connectionID)
		{
			return default(ConnectionStatus);
		}

		public ConnectionStatus AllConnectStatus()
		{
			return default(ConnectionStatus);
		}

		public virtual void Init(string[] connectionChannels)
		{
		}

		public virtual void Shutdown()
		{
		}

		public virtual void Start()
		{
		}

		public virtual void Stop()
		{
		}

		public uint Connect(UserInfo userInfo, out int connectionID)
		{
			connectionID = default(int);
			return 0u;
		}

		private void CheckReader(PlatformID platformID)
		{
		}

		public uint Disconnect(UserInfo userInfo)
		{
			return 0u;
		}

		public void DisconnectAll()
		{
		}

		public uint Send(UserInfo targetUser, int channel, byte[] data, uint length)
		{
			return 0u;
		}

		public virtual uint Receive(out int connectionID, out int channel, byte[] data, int dataMax, out int received, out NetTransportUpdate updateEvent)
		{
			connectionID = default(int);
			channel = default(int);
			received = default(int);
			updateEvent = default(NetTransportUpdate);
			return 0u;
		}
	}
}
