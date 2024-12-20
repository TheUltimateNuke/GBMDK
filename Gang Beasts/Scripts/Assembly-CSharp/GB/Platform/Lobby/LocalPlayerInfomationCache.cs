using System;
using System.Runtime.CompilerServices;
using GB.UI.Beasts;

namespace GB.Platform.Lobby
{
	public class LocalPlayerInfomationCache
	{
		private BeastUtils.PlayerState _state;

		private int _playerID;

		private int _teamIndex;

		private int _costumeIndex;

		private int _colourIndex;

		private string _playerPrefCode;

		private int _localPlayerID;

		public bool dummy;

		public BeastUtils.PlayerState CurrentState
		{
			get
			{
				return default(BeastUtils.PlayerState);
			}
			set
			{
			}
		}

		public int PlayerID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int CostumeIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ColourIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int TeamIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public event Action<LocalPlayerInfomationCache, int, int> OnCostumeChange
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

		public event Action<LocalPlayerInfomationCache, int, int> OnColourChange
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

		public event Action<LocalPlayerInfomationCache, int, int> OnTeamChange
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

		public event Action<LocalPlayerInfomationCache, BeastUtils.PlayerState, BeastUtils.PlayerState> OnStateChange
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

		public LocalPlayerInfomationCache(int controller)
		{
		}

		public void LoadLastSettings()
		{
		}
	}
}
