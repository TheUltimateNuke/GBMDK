using System;
using GB.Gamemodes;
using UnityEngine.Localization;

namespace GB.UI
{
	[Serializable]
	public struct GameModeData
	{
		public GameModeEnum Mode;

		public LocalizedString ModeName;

		public LocalizedString ModeCondition;
	}
}
