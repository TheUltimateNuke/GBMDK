namespace UnityEngine.Networking.NetworkSystem
{
	internal class LobbyReadyToBeginMessage : MessageBase
	{
		public byte slotId;

		public bool readyState;

		public override void Deserialize(NetworkReader reader)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}
	}
}
