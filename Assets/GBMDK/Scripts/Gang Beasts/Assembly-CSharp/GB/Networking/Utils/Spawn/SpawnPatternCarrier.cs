using System;
using System.Collections.Generic;
using GB.Gamemodes;
using GB.Utils;
using UnityEngine;

namespace GB.Networking.Utils.Spawn
{
	[CreateAssetMenu(fileName = "SpawnPattern", menuName = "Gang Beasts/Data/Game/Spawn Pattern", order = 1)]
	public class SpawnPatternCarrier : ScriptableObject
	{
		[Serializable]
		public class Pattern
		{
			[SerializeField]
			[EnumUtils.EnumFlags]
			[Tooltip("Needed gamemode")]
			public GameModeEnum Mode;

			[Tooltip("Needed Min Gangs")]
			[SerializeField]
			public int MinGangs;

			[Tooltip("Needed Max Gangs")]
			[SerializeField]
			public int MaxGangs;

			[SerializeField]
			public List<int> SpawnOptions;
		}

		[SerializeField]
		private List<Pattern> _options;

		public Pattern FindActivePattern()
		{
			return null;
		}

		public Pattern[] FindPatterns(GameModeEnum mode, int gangs)
		{
			return null;
		}
	}
}
