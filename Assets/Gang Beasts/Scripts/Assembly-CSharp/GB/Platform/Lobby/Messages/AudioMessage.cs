using CS.CorePlatform.Utils.Data;

namespace GB.Platform.Lobby.Messages
{
	public class AudioMessage : LobbyMessage
	{
		private string _clipName;

		public string ClipName
		{
			get
			{
				return null;
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
