namespace GB.UnityServices.Matchmaking
{
	public class MatchmakingFilters
	{
		public MatchmakingPlatformBucket MatchmakingPlatformBucket { get; set; }

		public int MatchmakingMode { get; set; }

		public double Version { get; set; }

		public bool PrivateGame { get; set; }

		public uint HostDefinedBeastCount { get; set; }

		public uint LobbyTotalBeastCount { get; set; }
	}
}
