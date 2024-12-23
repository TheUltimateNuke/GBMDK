using UnityEngine.Networking;

namespace CoreNet.Objects
{
	public class NetConnection : NetObject
	{
		public NetworkConnection Value;

		public bool Authenticated;

		public bool Debug;

		public NetConnection()
		{
		}

		public NetConnection(NetworkConnection value)
		{
		}

		public bool IsNull()
		{
			return false;
		}

		public override void Serialize(NetworkWriter writer)
		{
		}

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(NetConnection conn)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
