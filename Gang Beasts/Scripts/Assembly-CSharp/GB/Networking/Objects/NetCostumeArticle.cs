using UnityEngine.Networking;

namespace GB.Networking.Objects
{
	public class NetCostumeArticle : MessageBase
	{
		public ushort ItemId;

		public ushort ColorId;

		public NetCostumeArticle()
		{
		}

		public NetCostumeArticle(ushort itemID, ushort colorId = 0)
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
