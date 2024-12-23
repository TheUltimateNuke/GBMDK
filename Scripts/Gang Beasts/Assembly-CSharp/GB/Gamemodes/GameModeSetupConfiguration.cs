using UnityEngine;

namespace GB.Gamemodes
{
	public class GameModeSetupConfiguration : ScriptableObject
	{
		public const string DefaultGameSetupConfig = "GameModeSetupConfiguration";

		[SerializeField]
		private GameModeMapTracker _mapModes;

		[SerializeField]
		private GameModePlayerSetupCollection _playerSetup;

		public GameModeMapTracker Maps => null;

		public GameModePlayerSetupCollection PlayerSetup => null;
	}
}
