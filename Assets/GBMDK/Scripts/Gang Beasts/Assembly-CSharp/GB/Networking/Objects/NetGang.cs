using CoreNet.Objects;
using GB.Data;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Networking.Objects
{
	public class NetGang : NetObject
	{
		public int GangID;

		public Color GangColor;

		public Color CostumeColor;

		public int GangMapScore;

		public int GangPlaylistScore;

		public NetGang()
		{
		}

		public NetGang(int gangId, Color gangColor, Color costumeColor, int startingScore)
		{
		}

		public NetGang(int gangId, ColorCache color, int startingScore)
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
