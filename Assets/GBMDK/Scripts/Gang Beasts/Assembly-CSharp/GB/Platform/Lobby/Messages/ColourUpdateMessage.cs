using System.Collections.Generic;
using CS.CorePlatform.Utils.Data;

namespace GB.Platform.Lobby.Messages
{
	public class ColourUpdateMessage : LobbyMessage
	{
		private LobbyColourLocker.ColourLock[] _locks;

		public int Total => 0;

		public ColourUpdateMessage()
		{
		}

		public ColourUpdateMessage(ColourUpdateMessage copy)
		{
		}

		public void Copy(ColourUpdateMessage copy)
		{
		}

		public void UpdateColourLocks(List<LobbyColourLocker.ColourLock> data)
		{
		}

		public LobbyColourLocker.ColourLock GetData(int i)
		{
			return null;
		}

		protected override void Serialize(DataWriter writer)
		{
		}

		public override void DeserializeFromLobbyMessage(DataReader reader)
		{
		}
	}
}
