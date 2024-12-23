using UnityEngine.Networking;

namespace CoreNet.Objects
{
	public class NetMember : NetConnectionAssociation
	{
		public bool Loaded;

		public bool Spectating;

		public string CurrentScene;

		public bool Paused;

		public bool Setup;

		public NetMember()
		{
		}

		public NetMember(NetworkConnection conn)
		{
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

		public bool Equals(NetMember member)
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
