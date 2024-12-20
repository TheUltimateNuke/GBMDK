using System;
using System.Runtime.CompilerServices;
using CS.CorePlatform;
using UnityEngine;

namespace GB.Platform.Lobby
{
	public class LobbyManager : MonoBehaviour
	{
		private BaseUserInfo _userCache;

		private static LobbyManager _instance;

		private GameObject _objectCache;

		private bool _completedSetup;

		private LobbyJoinEvents _joinEvents;

		private LobbyPlayerManager _players;

		private OnlineBeastSetupTracker _onlineBeasts;

		private LocalBeastSetupTracker _localBeasts;

		private LocalBeastMessageSender _beastMessageSender;

		private LobbyVoiceStates _voiceStates;

		private LobbyState _lobbyStates;

		private LobbyConnections _connections;

		private LocalAccountManager _localAccounts;

		private LobbyColourLocker _colourLocker;

		public BaseUserInfo MeCache => default(BaseUserInfo);

		public static LobbyManager Instance => null;

		public GameObject LobbyObject => null;

		public LobbyPlayerManager Players => null;

		public OnlineBeastSetupTracker OnlineBeasts => null;

		public LocalBeastSetupTracker LocalBeasts => null;

		public LocalBeastMessageSender BeastMessageSender => null;

		public LobbyVoiceStates VoiceStates => null;

		public LobbyState LobbyStates => null;

		public LobbyConnections Connections => null;

		public LocalAccountManager LocalAccounts => null;

		public LobbyColourLocker ColourLocker => null;

		private static event Action onSetupComplete
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

		public static void SetupAdd(Action add)
		{
		}

		public static void SetupRemove(Action remove)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateUser(bool change)
		{
		}

		private void UpdateUser()
		{
		}

		private void OnPlatformInitializedEvent()
		{
		}

		private void PlatformEvents_OnLobbyLeftEvent()
		{
		}
	}
}
