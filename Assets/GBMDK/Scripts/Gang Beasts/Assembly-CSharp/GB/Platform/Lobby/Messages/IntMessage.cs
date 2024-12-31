using CS.CorePlatform.Utils.Data;

namespace GB.Platform.Lobby.Messages
{
	public class IntMessage : LobbyMessage
	{
		private int _value;

		public int Value
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
