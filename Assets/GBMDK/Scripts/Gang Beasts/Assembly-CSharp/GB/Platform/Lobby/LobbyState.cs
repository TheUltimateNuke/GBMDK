using System;
using System.Runtime.CompilerServices;
using CS.CorePlatform;
using Coatsink.UnityServices.Matchmaking;
using GB.Gamemodes;
using GB.Platform.Lobby.Messages;
using UnityEngine;

namespace GB.Platform.Lobby
{
	public class LobbyState : LobbyPart
	{
		[Flags]
		public enum State
		{
			Unknown = 0,
			Ready = 1,
			InGame = 2,
			Joinable = 4,
			Editable = 8,
			Matching = 0x10
		}

		public static class SetStates
		{
			public const State Searching = State.Ready | State.Matching;

			public const State Playing = State.Ready | State.InGame;

			public const State LobbyIdle = State.Ready | State.Joinable | State.Editable;

			public const State LobbyCountdown = State.Ready | State.Joinable | State.Editable | State.Matching;
		}

		public enum Game
		{
			Unknown = 0,
			Menu = 1,
			Local = 2,
			Online = 3,
			Wireless = 4
		}

		private LobbyMessage _pergeMessage;

		private ClientReadyToJoinMessage _clientReadyToJoinMessage;

		private BaseUserInfo _hostCache;

		private State _lobbyState;

		private string _IP;

		private int _port;

		private LobbyInfo _message;

		private JoinGameEvent joinMessage;

		private Game _selfState;

		private GameModeEnum _mode;

		private bool _private;

		private bool _drawInspector;

		public BaseUserInfo Host => default(BaseUserInfo);

		public State CurrentState
		{
			get
			{
				return default(State);
			}
			set
			{
			}
		}

		public string IP
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Port
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Game SelfState
		{
			get
			{
				return default(Game);
			}
			set
			{
			}
		}

		public GameModeEnum Mode
		{
			get
			{
				return default(GameModeEnum);
			}
			set
			{
			}
		}

		public bool Private
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static event Action OnStateChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnGameModeChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnGameSelfStateChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Awake()
		{
		}

		private void CheckLeaveReason()
		{
		}

		private void OnDestroy()
		{
		}

		public override void ClearData()
		{
		}

		private void HostChanged(BaseUserInfo info)
		{
		}

		private void OnCreatingLobby()
		{
		}

		private void OnLobbyInfoReceived(BaseUserInfo arg1, LobbyInfo arg2)
		{
		}

		private void OnLobbyRequested(BaseUserInfo arg1, LobbyMessage arg2)
		{
		}

		public void UpdateLobbyState()
		{
		}

		public void MatchmakingComplete(MatchmakingResult clientResult)
		{
		}

		public void SendLobbyGameEvent(BaseUserInfo user, string targetIP, int targetPort)
		{
		}

		public void OnLobbyGameEvent(BaseUserInfo arg1, JoinGameEvent arg2)
		{
		}

		public void TriggerReadyPerge()
		{
		}

		private void OnPergeTriggered(BaseUserInfo arg1, LobbyMessage arg2)
		{
		}

		private bool ShouldPurge()
		{
			return false;
		}

		public void IsClientReadyToJoin()
		{
		}

		private void OnClientReadyRequested(BaseUserInfo arg1, ClientReadyToJoinMessage arg2)
		{
		}

		public override void DrawInspector()
		{
		}
	}
}
