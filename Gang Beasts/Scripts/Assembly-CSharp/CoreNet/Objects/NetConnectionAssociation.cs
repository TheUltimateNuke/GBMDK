using UnityEngine.Networking;

namespace CoreNet.Objects
{
	public abstract class NetConnectionAssociation : NetObject
	{
		public int ConnectionId;

		public NetConnectionAssociation()
		{
		}

		public NetConnectionAssociation(int connectionId)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}

		public override void Deserialize(NetworkReader reader)
		{
		}
	}
}
