using CS.CorePlatform;
using CS.CorePlatform.Utils.Data;
using Coatsink.Platform.Systems.User;
using Costumes;
using Femur;
using GB.Platform.Lobby.Utils;
using GB.UI.Beasts;

namespace GB.Platform.Lobby.Messages
{
	public class LobbySnapshot : LobbyMessage
	{
		private ConnectionStateBeast[] _states;

		public ConnectionStateBeast[] States => null;

		public void SetSize(int size)
		{
		}

		public void SetSize(int slot, int size)
		{
		}

		public void SetMainID(int slot, BaseUserInfo value)
		{
		}

		public void SetAllowed(int slot, int index, bool value)
		{
		}

		public void SetName(int slot, int index, string value)
		{
		}

		public void SetID(int slot, int index, OnlineID value)
		{
		}

		public void SetBeastInfo(int slot, int index, int controllerID, BeastUtils.PlayerState state, int team, int colour, Actor.Voice voice, CostumeSaveEntry costume)
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
