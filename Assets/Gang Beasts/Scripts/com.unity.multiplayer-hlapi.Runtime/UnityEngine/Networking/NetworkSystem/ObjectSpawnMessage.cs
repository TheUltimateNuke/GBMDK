namespace UnityEngine.Networking.NetworkSystem
{
	internal class ObjectSpawnMessage : MessageBase
	{
		public NetworkInstanceId netId;

		public NetworkHash128 assetId;

		public Vector3 position;

		public byte[] payload;

		public Quaternion rotation;

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}
	}
}
