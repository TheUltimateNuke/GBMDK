namespace GB.Platform.Lobby.Utils
{
	public static class LobbyCodes
	{
		public const string JOIN_REQUEST = "JOIN";

		public const string LEAVE_REQUEST = "LEAVE";

		public const string NO_SPACE = "NO_ROOM";

		public const string CONNECTION_FAIL = "FAILED_HOST_CONNECT";

		public const string BEAST_KICKED = "BEAST_KICKED";

		public const string SYSTEM_CONNECTION_LOST = "SYSTEM_CONNECTION_LOST";

		public const string VERSION_MISSMATCH = "VERSION_MISSMATCH";

		public static bool NeedsInforming(string code)
		{
			return false;
		}

		public static string CodeToKey(string error)
		{
			return null;
		}
	}
}
