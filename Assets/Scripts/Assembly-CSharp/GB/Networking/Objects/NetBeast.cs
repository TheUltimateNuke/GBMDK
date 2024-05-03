using CoreNet.Objects;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Networking.Objects
{
	public class NetBeast : NetPlayer
	{
		public NetCostume Costume;

		public Color PrimaryColor;

		public Color CostumeColor;

		public int GangId;

		public bool Dummy;

		public NetBeast()
		{
		}

		public NetBeast(int controllerId, NetCostume costume, Color primaryColor, Color costumeColor, int gangId = -1, PlayerType pType = PlayerType.Player, bool dummy = false)
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
