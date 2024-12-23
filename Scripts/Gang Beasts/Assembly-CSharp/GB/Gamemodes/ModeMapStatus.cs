using System;

namespace GB.Gamemodes
{
	[Serializable]
	public class ModeMapStatus
	{
		public string MapName;

		public bool Enabled;

		public GameModeEnum AllowedModesLocal;

		public GameModeEnum AllowedModesOnline;

		public ModeMapStatus()
		{
		}

		public ModeMapStatus(string mapName, bool enabled)
		{
		}
	}
}
