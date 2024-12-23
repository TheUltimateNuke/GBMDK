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
			Under_Player_Count = 3,
			Under_Team_Min_Count = 4
		}

		public int minPlayers;

		public int maxPlayers;

		public int minTeams;

		public int maxTeams;

		public static string ResultLocMessage(Result result)
		{
			return null;
		}

		public Result CheckValid(int totalBeasts, int totalTeams = 0)
		{
			return default(Result);
		}
	}
}
