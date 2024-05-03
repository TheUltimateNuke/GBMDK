using UnityEngine.Networking;

namespace GB.Networking.Objects
{
	public class NetCostumeCloudData : MessageBase
	{
		public string id;

		public string code;

		public string data;

		public string timestamp;

		public NetCostumeCloudData()
		{
		}

		public NetCostumeCloudData(CostumeCloudSaveLoad.CostumeCloudData cloudData)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public override void Serialize(NetworkWriter writer)
		{
		}

		public override void Deserialize(NetworkReader reader)
		{
		}
	}
}
