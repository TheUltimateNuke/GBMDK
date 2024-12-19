using System;

namespace GB.Gamemodes
{
	[Serializable]
	public class GameModePlayerSetup
	{
		public GameModeEnum mode;

		public GameModeNeeds publicNeeds;

		public bool hasPrivate;

		public bool hasWirelessNeeds;

		public GameModeNeeds privateNeeds;

		public GameModeNeeds wirelessNeeds;

		public GameModeNeeds GetNeeds(bool privateGame, bool isWirelessMode = false)
		{
			return default(GameModeNeeds);
		}
	}
}
