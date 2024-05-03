using CS.CorePlatform.Utils.Data;
using GB.Gamemodes;

namespace GB.Platform.Lobby.Messages
{
	public class LobbyInfo : LobbyMessage
	{
		private LobbyState.State _state;

		private int _maxTeam;

		private GameModeEnum _mode;

		private bool _private;

		public LobbyState.State State
		{
			get
			{
				return default(LobbyState.State);
			}
			set
			{
			}
		}

		public int MaxTeam
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public GameModeEnum Mode
		{
			get
			{
				return default(GameModeEnum);
			}
			set
			{
			}
		}

		public bool Private
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
