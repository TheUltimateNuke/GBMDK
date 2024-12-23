using Newtonsoft.Json;

namespace GB.UnityServices.Matchmaking
{
	public class MatchmakingPlayerModel
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		public GBGameData Data { get; set; }
	}
}
