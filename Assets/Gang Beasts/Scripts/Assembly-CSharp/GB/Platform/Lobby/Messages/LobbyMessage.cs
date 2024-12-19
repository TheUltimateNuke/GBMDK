using CS.CorePlatform.Utils.Data;

namespace GB.Platform.Lobby.Messages
{
	public class LobbyMessage : PlatformMessageBase
	{
		private byte _type;

		public byte Type
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

		protected override void Deserialize(DataReader reader)
		{
		}

		public virtual void DeserializeFromLobbyMessage(DataReader reader)
		{
		}
	}
}
