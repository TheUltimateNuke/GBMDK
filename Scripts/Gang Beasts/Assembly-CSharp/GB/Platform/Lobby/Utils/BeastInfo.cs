using CS.CorePlatform.Utils.Data;
using Costumes;
using Femur;
using GB.UI.Beasts;

namespace GB.Platform.Lobby.Utils
{
	public class BeastInfo
	{
		private int _controller;

		private BeastUtils.PlayerState _state;

		private int _team;

		private int _colour;

		private Actor.Voice _voice;

		private CostumeSaveEntry _costume;

		public int ControllerID => 0;

		public BeastUtils.PlayerState State => default(BeastUtils.PlayerState);

		public int Team => 0;

		public int Colour => 0;

		public Actor.Voice Voice => default(Actor.Voice);

		public CostumeSaveEntry Costume => null;

		public bool Copy(BeastInfo data)
		{
			return false;
		}

		public bool SetControllerID(int value)
		{
			return false;
		}

		public bool SetState(BeastUtils.PlayerState value)
		{
			return false;
		}

		public bool SetTeam(int value)
		{
			return false;
		}

		public bool SetColour(int value)
		{
			return false;
		}

		public bool SetVoice(Actor.Voice value)
		{
			return false;
		}

		public bool SetCostume(CostumeSaveEntry value)
		{
			return false;
		}

		public bool SetBeastInfo(int controllerID, BeastUtils.PlayerState state, int team, int colour, Actor.Voice voice, CostumeSaveEntry costume)
		{
			return false;
		}

		public void Serialize(DataWriter writer)
		{
		}

		public bool Deserialize(DataReader reader)
		{
			return false;
		}
	}
}
