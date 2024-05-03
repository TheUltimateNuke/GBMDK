using CS.CorePlatform.Utils.Data;

namespace GB.Platform.Lobby.Messages
{
	public class BoolMessage : LobbyMessage
	{
		private bool _active;

		public bool Active
		{
			get
			{
				return false;
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
