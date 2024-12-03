namespace UnityEngine.Networking.NetworkSystem
{
	internal class ObjectSpawnSceneMessage : MessageBase
	{
		public NetworkInstanceId netId;

		public NetworkSceneId sceneId;

		public Vector3 position;

		public byte[] payload;

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}
	}
}
