using System.Collections.Generic;
using System.Net;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.Online.Connections
{
	public class ConnectionCarrier
	{
		private readonly Dictionary<int, INetConnection> _indexConnection;

		private readonly Dictionary<UserInfo, INetConnection> _usersConnection;

		private readonly Dictionary<UserInfo, int> _usersIndex;

		private readonly Dictionary<int, UserInfo> _indexUser;

		private readonly List<int> _connections;

		private string[] _channelKeys;

		private int _nextConnection;

		public int TotalConnections => 0;

		public string[] Keys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int NextConnection
		{
			set
			{
			}
		}

		public INetConnection this[int i] => null;

		public INetConnection this[UserInfo i] => null;

		public UserInfo GetUser(int connectionID)
		{
			return default(UserInfo);
		}

		public int GetConnectionID(UserInfo userInfo)
		{
			return 0;
		}

		public int GetConnectionID(int i)
		{
			return 0;
		}

		private int FindFreeID()
		{
			return 0;
		}

		public uint AddConnection(UserInfo createConnection, out int connectionID)
		{
			connectionID = default(int);
			return 0u;
		}

		public uint Disconnect(UserInfo disconnect)
		{
			return 0u;
		}

		private uint Disconnect(int connectionID, UserInfo userID)
		{
			return 0u;
		}

		private void Cleanup(int connectionID, UserInfo userID)
		{
		}

		public void DisconnectAll(bool cleanup)
		{
		}

		public bool UpdateConnections(out int connectionID, out ConnectionStatus status)
		{
			connectionID = default(int);
			status = default(ConnectionStatus);
			return false;
		}

		public int ParseSender(UserInfo senderInfo, EndPoint endPoint)
		{
			return 0;
		}

		public ConnectionStatus AllConnectStatus()
		{
			return default(ConnectionStatus);
		}
	}
}
