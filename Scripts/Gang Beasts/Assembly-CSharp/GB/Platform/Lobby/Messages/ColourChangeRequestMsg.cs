using CS.CorePlatform;
using CS.CorePlatform.Utils.Data;

namespace GB.Platform.Lobby.Messages
{
	public class ColourChangeRequestMsg : LobbyMessage
	{
		public enum ColourChange
		{
			Clear = 0,
			Request = 1,
			Move = 2
		}

		private BaseUserInfo _userInfo;

		private int controllerID;

		private int colourChangeDir;

		private ColourChange _effect;

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

		public int ControllerID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ColourID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ColourChange ColourEffect
		{
			get
			{
				return default(ColourChange);
			}
			set
			{
			}
		}

		public ColourChangeRequestMsg()
		{
		}

		public ColourChangeRequestMsg(ColourChangeRequestMsg copy)
		{
		}

		public void Copy(ColourChangeRequestMsg copy)
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
