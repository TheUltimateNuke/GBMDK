using CS.CorePlatform.Utils.Data;

namespace GB.Platform.Lobby.Messages
{
	public class StringMessage : LobbyMessage
	{
		private string _value;

		public string Value
		{
			get
			{
				return null;
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
