using CS.CorePlatform;
using CS.CorePlatform.Utils.Data;
using Coatsink.Platform.Systems.User;
using Costumes;
using Femur;
using GB.Platform.Lobby.Utils;
using GB.UI.Beasts;

namespace GB.Platform.Lobby.Messages
{
	public class JoinRequest : LobbyMessage
	{
		private BaseUserInfo _userInfo;

		private int _controllerID;

		private bool _allowed;

		private string _name;

		private string _info;

		private OnlineID _id;

		private double _networkVersion;

		private BeastInfo _beastInfo;

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

		public bool Allowed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Info
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public OnlineID ID
		{
			get
			{
				return default(OnlineID);
			}
			set
			{
			}
		}

		public double NetVersion
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public BeastInfo BeastInfo => null;

		public void SetBeastInfo(BeastUtils.PlayerState state, int team, int colour, Actor.Voice voice, CostumeSaveEntry costume)
		{
		}

		public void SetBeastColour(int colour)
		{
		}

		public void ClearBeastInfo()
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
