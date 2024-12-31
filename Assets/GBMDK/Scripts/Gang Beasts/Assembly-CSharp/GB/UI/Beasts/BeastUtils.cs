namespace GB.UI.Beasts
{
	public class BeastUtils
	{
		public enum PlayerState
		{
			InActive = 0,
			Designing = 1,
			Ready = 2
		}

		public const int PlayerID_None = -1;

		public const int PlayerID_Local = 0;

		public const int PlayerID_Lobby = 16;

		public const int PlayerID_AI = 256;

		public static bool PlayerIDNone(int playerID)
		{
			return false;
		}

		public static bool PlayerIDLocal(int playerID)
		{
			return false;
		}

		public static bool PlayerIDLobby(int playerID)
		{
			return false;
		}

		public static bool PlayerIDAI(int playerID)
		{
			return false;
		}

		public static int PlayerToController(int playerID)
		{
			return 0;
		}

		public static int TeamLoop(int team, int max)
		{
			return 0;
		}
	}
}
