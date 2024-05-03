using CS.CorePlatform;
using CS.CorePlatform.Utils.Data;
using Coatsink.Platform.Systems.User;

namespace GB.Platform.Lobby.Utils
{
	public class ConnectionState
	{
		private BaseUserInfo _userInfo;

		private bool[] _allowed;

		private string[] _name;

		private OnlineID[] _id;

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

		public virtual bool SetSize(int size)
		{
			return false;
		}

		public bool SetAllowed(int index, bool value)
		{
			return false;
		}

		public bool SetName(int index, string value)
		{
			return false;
		}

		public bool SetID(int index, OnlineID value)
		{
			return false;
		}

		public virtual void Serialize(DataWriter writer)
		{
		}

		public virtual bool Deserialize(DataReader reader)
		{
			return false;
		}
	}
}
