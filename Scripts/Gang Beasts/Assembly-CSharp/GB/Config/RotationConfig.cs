using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GB.Config
{
	[Serializable]
	public class RotationConfig
	{
		[JsonProperty("random")]
		public bool Random;

		[JsonProperty("restart_on_completion")]
		public bool RestartOnCompletion;

		[JsonProperty("max_players")]
		public int MaxPlayers;

		[JsonProperty("wins")]
		public int Wins;

		[JsonProperty("stage_time_limit")]
		public int StageTimeLimit;

		[JsonProperty("games")]
		public List<GameConfig> GameConfigs;
	}
}
