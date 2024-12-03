namespace UnityEngine.Networking.NetworkSystem
{
	internal class ObjectSpawnFinishedMessage : MessageBase
	{
		public uint state;

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}
	}
}
