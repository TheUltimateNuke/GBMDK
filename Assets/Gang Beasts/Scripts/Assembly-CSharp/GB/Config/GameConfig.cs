using System;
using Newtonsoft.Json;

namespace GB.Config
{
	[Serializable]
	public class GameConfig
	{
		[JsonProperty("map")]
		public string Map;

		[JsonProperty("mode")]
		public string Mode;

		[JsonProperty("max_score")]
		public int Score;
	}
}
