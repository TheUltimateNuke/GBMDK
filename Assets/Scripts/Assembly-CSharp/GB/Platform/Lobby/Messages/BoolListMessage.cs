using System.Collections.Generic;
using CS.CorePlatform.Utils.Data;

namespace GB.Platform.Lobby.Messages
{
	public class BoolListMessage : LobbyMessage
	{
		private List<bool> _list;

		public int Total => 0;

		public void SetPoint(int index, bool value)
		{
		}

		public bool GetPoint(int index)
		{
			return false;
		}

		protected override void Serialize(DataWriter writer)
		{
		}

		public override void DeserializeFromLobbyMessage(DataReader reader)
		{
		}
	}
}
