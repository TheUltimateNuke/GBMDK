using CS.CorePlatform.Utils.Data;
using Costumes;
using Femur;
using GB.UI.Beasts;

namespace GB.Platform.Lobby.Utils
{
	public class ConnectionStateBeast : ConnectionState
	{
		private BeastInfo[] _beastInfo;

		public BeastInfo[] BeastInfo => null;

		public bool SetBeastInfo(int slot, int controllerID, BeastUtils.PlayerState state, int team, int colour, Actor.Voice voice, CostumeSaveEntry costume)
		{
			return false;
		}

		public override bool SetSize(int size)
		{
			return false;
		}

		public override void Serialize(DataWriter writer)
		{
		}

		public override bool Deserialize(DataReader reader)
		{
			return false;
		}
	}
}
