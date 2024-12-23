namespace UnityEngine.Networking.NetworkSystem
{
	internal class OwnerMessage : MessageBase
	{
		public NetworkInstanceId netId;

		public short playerControllerId;

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}
	}
}
