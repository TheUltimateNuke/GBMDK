using System;

namespace GB.Gamemodes
{
	public static class GameModeHelpers
	{
		public static GameModeEnum Next(this GameModeEnum current)
		{
			return default(GameModeEnum);
		}

		public static GameModeEnum Previous(this GameModeEnum current)
		{
			return default(GameModeEnum);
		}

		public static int GetPublicMatchWinCountForGamemode(this GameModeEnum current)
		{
			return 0;
		}

		public static int GetPublicMatchStageTimeForGamemode(this GameModeEnum current)
		{
			return 0;
		}

		public static bool[] DeflagModeEnum(GameModeEnum num)
		{
			return null;
		}

		public static GameModeEnum ReflagModeEnum(bool[] values)
		{
			return default(GameModeEnum);
		}

		public static string GetDescription(this Enum value)
		{
			return null;
		}

		public static string GetGameModeID(this GameModeEnum value)
		{
			return null;
		}

		public static GameModeEnum GamemodeIDToEnum(string ID)
		{
			return default(GameModeEnum);
		}
	}
}
