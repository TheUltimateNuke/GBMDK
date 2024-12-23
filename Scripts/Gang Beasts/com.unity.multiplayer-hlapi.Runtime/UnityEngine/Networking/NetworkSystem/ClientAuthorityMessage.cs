namespace UnityEngine.Networking.NetworkSystem
{
	internal class ClientAuthorityMessage : MessageBase
	{
		public NetworkInstanceId netId;

		public bool authority;

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}
	}
}
