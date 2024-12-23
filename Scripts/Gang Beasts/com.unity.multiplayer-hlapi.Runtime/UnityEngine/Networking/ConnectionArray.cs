using System.Collections.Generic;

namespace UnityEngine.Networking
{
	internal class ConnectionArray
	{
		private List<NetworkConnection> m_LocalConnections;

		private List<NetworkConnection> m_Connections;

		internal List<NetworkConnection> localConnections => null;

		internal List<NetworkConnection> connections => null;

		public int Count => 0;

		public int LocalIndex => 0;

		public int Add(int connId, NetworkConnection conn)
		{
			return 0;
		}

		public NetworkConnection Get(int connId)
		{
			return null;
		}

		public NetworkConnection GetUnsafe(int connId)
		{
			return null;
		}

		public void Remove(int connId)
		{
		}

		public int AddLocal(NetworkConnection conn)
		{
			return 0;
		}

		public bool ContainsPlayer(GameObject player, out NetworkConnection conn)
		{
			conn = null;
			return false;
		}
	}
}
