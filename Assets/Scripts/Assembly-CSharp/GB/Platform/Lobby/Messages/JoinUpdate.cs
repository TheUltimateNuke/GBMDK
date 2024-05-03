using CS.CorePlatform;
using CS.CorePlatform.Utils.Data;
using Coatsink.Platform.Systems.User;
using GB.Platform.Lobby.Utils;

namespace GB.Platform.Lobby.Messages
{
	public class JoinUpdate : LobbyMessage
	{
		private ConnectionState _state;

		public BaseUserInfo UserInfo
		{
			get
			{
				return default(BaseUserInfo);
			}
			set
			{
			}
		}

		public bool[] Allowed => null;

		public string[] Name => null;

		public OnlineID[] ID => null;

		public void SetSize(int size)
		{
		}

		public void SetAllowed(int index, bool value)
		{
		}

		public void SetName(int index, string value)
		{
		}

		public void SetID(int index, OnlineID value)
		{
		}

		protected override void Serialize(DataWriter writer)
		{
		}

		public override void DeserializeFromLobbyMessage(DataReader reader)
		{
		}
	}
}
