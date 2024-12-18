using System.Collections.Generic;
using CS.CorePlatform;
using GB.Gamemodes;

namespace GB.UnityServices.Matchmaking
{
	public static class MatchmakingUtils
	{
		public enum MatchmakingPool
		{
			None = 0,
			LocalisationB = 1,
			ProductionA = 2,
			ProductionB = 3,
			ProductionC = 6,
			DevelopmentA = 4,
			DevelopmentB = 5
		}

		private const string logPrefix = "[MatchmakingUtils]";

		public const string PlatformKey = "platform";

		public const string VersionKey = "version";

		public const string PrivateKey = "private";

		public const string GamemodeKey = "gamemode";

		public const string MatchmakingModeKey = "matchmakingmode";

		public const string MapKey = "map";

		public const string LobbyBeastCount = "lobbybeastcount";

		public const string HostBeastCount = "hostbeastcount";

		public const string EncryptionKey = "encryptionkey";

		public const string DataKey = "data";

		public const string PlayersKey = "players";

		public static MatchmakingPlatformBucket GetMatchmakingPlatformBucket(PlatformKeys platformKey)
		{
			return default(MatchmakingPlatformBucket);
		}

		public static MatchmakingMode GetMatchmakingMode(GameModeEnum gameMode)
		{
			return default(MatchmakingMode);
		}

		public static HashSet<string> CombineUniqueMatchmakerPlayerIds(MatchmakingTicketModel ticket)
		{
			return null;
		}

		public static uint GetTotalPlayerCountExclLocal(MatchmakingTicketModel ticket)
		{
			return 0u;
		}

		public static uint GetTotalPlayerCountInclLocal(MatchmakingTicketModel ticket)
		{
			return 0u;
		}
	}
}
