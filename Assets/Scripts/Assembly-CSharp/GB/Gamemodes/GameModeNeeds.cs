using System;

namespace GB.Gamemodes
{
	[Serializable]
	public struct GameModeNeeds
	{
		public enum Result
		{
			Pass = 0,
			Online_Not_Needed = 1,
			Over_Player_Count = 2,
			Under_Player_Count = 3
		}

		public int minPlayers;

		public int maxPlayers;

		public int maxTeams;

		public static string ResultLocMessage(Result result)
		{
			return null;
		}

		public Result CheckValid(int totalBeasts)
		{
			return default(Result);
		}
	}
}
