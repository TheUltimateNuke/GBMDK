namespace UnityEngine.Networking.NetworkSystem
{
	internal class CRCMessage : MessageBase
	{
		public CRCMessageEntry[] scripts;

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}
	}
}
