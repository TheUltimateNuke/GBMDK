using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CS.CorePlatform;
using Femur;
using GB.Platform.Lobby.Messages;
using GB.Platform.Lobby.Utils;
using GB.UI.Beasts;
using UnityEngine;

namespace GB.Platform.Lobby
{
	public class OnlineBeastSetupTracker : LobbyPart
	{
		private List<OnlinePlayerInfomationCache> _activeBeasts;

		private LobbyMessage _costumeRequest;

		private Dictionary<BaseUserInfo, OnlinePlayerInfomationCache[]> _lobbyBeasts;

		private bool _drawInspector;

		public int TotalActiveBeasts => 0;

		public static event Action<OnlinePlayerInfomationCache, BeastUtils.PlayerState> OnStateChange
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

		public static event Action<OnlinePlayerInfomationCache, int> OnTeamChange
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

		public static event Action<OnlinePlayerInfomationCache> OnCostumeChange
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

		public static event Action<OnlinePlayerInfomationCache> OnColourChange
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

		public static event Action<OnlinePlayerInfomationCache, Actor.Voice> OnVoiceChange
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

		public OnlinePlayerInfomationCache GetActiveBeast(int index)
		{
			return null;
		}

		public OnlinePlayerInfomationCache GetPlayerInfo(int playerID)
		{
			return null;
		}

		public OnlinePlayerInfomationCache GetPlayerInfo(BaseUserInfo userInfo, int controllerID)
		{
			return null;
		}

		public BaseUserInfo GetPlatformUserInfo(int playerID)
		{
			return default(BaseUserInfo);
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public override void ClearData()
		{
		}

		private void OnPlayerJoined(BaseUserInfo user, int playerID)
		{
		}

		private void OnPlayerLeft(BaseUserInfo user)
		{
		}

		private void OnBeastCostumeRecieved(BaseUserInfo user, BeastInfoMesssage message)
		{
		}

		public void ForceUpdateBeast(BaseUserInfo user, BeastInfo info)
		{
		}

		private void OnlineBeastSetupTracker_OnVoiceChange(OnlinePlayerInfomationCache arg1, Actor.Voice arg2)
		{
		}

		private void OnlineBeastSetupTracker_OnTeamChange(OnlinePlayerInfomationCache arg1, int arg2)
		{
		}

		private void OnlineBeastSetupTracker_OnStateChange(OnlinePlayerInfomationCache arg1, BeastUtils.PlayerState arg2)
		{
		}

		private void OnlineBeastSetupTracker_OnCostumeChange(OnlinePlayerInfomationCache obj)
		{
		}

		private void OnlineBeastSetupTracker_OnColourChange(OnlinePlayerInfomationCache obj)
		{
		}

		public override void DrawInspector()
		{
		}
	}
}
