namespace PlayFab.Party
{
	public class PlayFabNetworkConfiguration
	{
		private uint _maxPlayerCount;

		private const uint _MAX_SUPPORTED_PLAYER_COUNT = 32u;

		private const string _ErrorMessageMaxUserCountValueOutOfRange = "Value must be between 1 and {0}";

		public uint MaxPlayerCount
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}
	}
}
