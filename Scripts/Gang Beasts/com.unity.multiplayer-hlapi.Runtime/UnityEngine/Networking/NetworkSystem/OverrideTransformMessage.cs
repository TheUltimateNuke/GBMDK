namespace UnityEngine.Networking.NetworkSystem
{
	internal class OverrideTransformMessage : MessageBase
	{
		public NetworkInstanceId netId;

		public byte[] payload;

		public bool teleport;

		public int time;

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}
	}
}
