using System;
using GB.Gamemodes;
using UnityEngine;

namespace GB.Game.Escalation
{
	[Serializable]
	public class EscalationData : ScriptableObject
	{
		[Serializable]
		public struct EscalationSceneData
		{
			public string sceneName;

			public bool enableEscalations;

			[SerializeField]
			public GameModeEscalation[] gameModeData;

			public void Init(string sceneName)
			{
			}
		}

		[Serializable]
		public struct GameModeEscalation
		{
			public GameModeEnum gamemode;

			public int escalationDuration;

			public bool enableMinorEscalations;

			public bool enableMajorEscalations;

			public bool enableFinalEscalations;

			public bool enableEscalateOnPlayerDeath;
		}

		[SerializeField]
		public EscalationSceneData sceneData;
	}
}
