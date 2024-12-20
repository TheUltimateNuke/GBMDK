using CS.CorePlatform.Utils.Data;
using Costumes;
using Femur;
using GB.Platform.Lobby.Utils;
using GB.UI.Beasts;

namespace GB.Platform.Lobby.Messages
{
	public class BeastInfoMesssage : LobbyMessage
	{
		private BeastInfo _beastInfo;

		private int _controller;

		private BeastUtils.PlayerState _state;

		private int _team;

		private int _colour;

		private Actor.Voice _voice;

		private CostumeSaveEntry _costume;

		public BeastInfo Info => null;

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

		public BeastUtils.PlayerState State
		{
			get
			{
				return default(BeastUtils.PlayerState);
			}
			set
			{
			}
		}

		public int Team
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Colour
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Actor.Voice Voice
		{
			get
			{
				return default(Actor.Voice);
			}
			set
			{
			}
		}

		public CostumeSaveEntry Costume
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BeastInfoMesssage()
		{
		}

		public BeastInfoMesssage(BeastInfoMesssage copy)
		{
		}

		public void Copy(BeastInfoMesssage copy)
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
