using CoreNet.Objects;
using UnityEngine.Networking;

namespace GB.Networking.Objects
{
	public class NetBeastRef : NetConnectionAssociation
	{
		private NetPlayer.PlayerType Type;

		private int ControllerID;

		public NetBeastRef(NetBeast beast)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
