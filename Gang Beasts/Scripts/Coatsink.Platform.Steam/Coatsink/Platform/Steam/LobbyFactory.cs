using System;
using Coatsink.Platform.Systems.Online;
using Steamworks;

namespace Coatsink.Platform.Steam
{
	public class LobbyFactory : ILobbyFactory
	{
		public static string STEAM_LOBBY_ARG;

		private Func<bool> _steamCheck;

		private Callback<GameLobbyJoinRequested_t> _callbackOnGameLobbyJoinRequested;

		private Callback<NewUrlLaunchParameters_t> _callbackOnNewLaunchCheckRequested;

		private int _maxCommandLine;

		public LobbyFactory(Func<bool> steamActiveCheck, string launchArgs = null, bool checkSteamCommand = true, int maxSteamCommandLenght = 256)
		{
		}

		~LobbyFactory()
		{
		}

		public ILobby CreateLobby()
		{
			return null;
		}

		public uint EndMultiplayer()
		{
			return 0u;
		}

		protected void OnJoinLobby(GameLobbyJoinRequested_t message)
		{
		}

		protected void OnNewLaunchCheck(NewUrlLaunchParameters_t message)
		{
		}

		private bool CheckSteamCommands()
		{
			return false;
		}

		public ILobbyID CheckForInvite(string launchArgs)
		{
			return null;
		}
	}
}
