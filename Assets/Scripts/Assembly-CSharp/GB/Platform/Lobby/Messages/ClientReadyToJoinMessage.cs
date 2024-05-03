using CS.CorePlatform.Utils.Data;

namespace GB.Platform.Lobby.Messages
{
	public class ClientReadyToJoinMessage : LobbyMessage
	{
		private bool _clientReady;

		public bool ClientReady
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override void DeserializeFromLobbyMessage(DataReader reader)
		{
		}

		protected override void Serialize(DataWriter writer)
		{
		}
	}
}
