using CS.CorePlatform.Utils.Data;

namespace GB.Platform.Lobby.Messages
{
	public class JoinGameEvent : LobbyMessage
	{
		private string _ip;

		private int _port;

		public string IP
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Port
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override void Serialize(DataWriter writer)
		{
		}

		public override void DeserializeFromLobbyMessage(DataReader reader)
		{
		}
	}
}
