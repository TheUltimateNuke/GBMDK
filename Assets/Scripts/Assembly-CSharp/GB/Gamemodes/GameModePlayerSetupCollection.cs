using System;
using System.Collections.Generic;

namespace GB.Gamemodes
{
	[Serializable]
	public class GameModePlayerSetupCollection
	{
		public List<GameModePlayerSetup> PlayerSetup;

		public GameModeNeeds GetNeeds(GameModeEnum mode, bool privateGame)
		{
			return default(GameModeNeeds);
		}
	}
}
