using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GB.UI.Beasts;
using UnityEngine;

namespace GB.Platform.Lobby
{
	public class LocalBeastSetupTracker : LobbyPart
	{
		private int _maxTeam;

		private LocalPlayerInfomationCache[] PlayerInfo;

		private bool _drawInspector;

		public int MaxTeam
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public LocalPlayerInfomationCache this[int i] => null;

		public int TotalPlayers => 0;

		public static event Action OnMaxTeamChange
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

		public static event Action<LocalPlayerInfomationCache, int> OnCostumeChange
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

		public static event Action<LocalPlayerInfomationCache, int> OnColourChange
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

		public static event Action<LocalPlayerInfomationCache, int> OnTeamChange
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

		public static event Action<LocalPlayerInfomationCache, BeastUtils.PlayerState> OnStateChange
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

		public LocalPlayerInfomationCache GetPlayerInfo(int playerID)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void LoadLastSettings()
		{
		}

		private void StateChange(LocalPlayerInfomationCache player, BeastUtils.PlayerState old, BeastUtils.PlayerState newValue)
		{
		}

		private void CostumeChange(LocalPlayerInfomationCache player, int old, int newValue)
		{
		}

		private void ColourChange(LocalPlayerInfomationCache player, int old, int newValue)
		{
		}

		private void TeamChange(LocalPlayerInfomationCache player, int old, int newValue)
		{
		}

		public void ForceAllTo(BeastUtils.PlayerState value)
		{
		}

		public void ForceAllAToB(BeastUtils.PlayerState stateA, BeastUtils.PlayerState stateB)
		{
		}

		public int TotalInState(BeastUtils.PlayerState after)
		{
			return 0;
		}

		public List<int> PlayersInState(BeastUtils.PlayerState after, List<int> cache = null)
		{
			return null;
		}

		public List<int> PlayersNotInState(BeastUtils.PlayerState notThis, List<int> cache = null)
		{
			return null;
		}

		public bool AllActiveBeastsReady(bool requireAtleastOneBeast = true)
		{
			return false;
		}

		public int SetupNetMemberContext(bool lobby)
		{
			return 0;
		}

		public override void DrawInspector()
		{
		}
	}
}
