using System;

namespace GB.Gamemodes
{
	[Serializable]
	public class GameModePlayerSetup
	{
		public GameModeEnum mode;

		public GameModeNeeds publicNeeds;

		public bool hasPrivate;

		public GameModeNeeds privateNeeds;

		public GameModeNeeds GetNeeds(bool privateGame)
		{
			return default(GameModeNeeds);
		}
	}
}
