using System;
using System.Runtime.CompilerServices;
using Costumes;
using Femur;
using GB.Platform.Lobby.Utils;
using GB.UI.Beasts;

namespace GB.Platform.Lobby
{
	public class OnlinePlayerInfomationCache
	{
		private BeastUtils.PlayerState _state;

		private int _playerID;

		private int _controllerID;

		private int _teamIndex;

		private int _colour;

		private Actor.Voice _voice;

		private CostumeSaveEntry _costumArray;

		public BeastUtils.PlayerState State => default(BeastUtils.PlayerState);

		public int PlayerID => 0;

		public int ControllerID => 0;

		public int TeamIndex => 0;

		public int Colour => 0;

		public Actor.Voice Voice => default(Actor.Voice);

		public CostumeSaveEntry CostumArray => null;

		public event Action<OnlinePlayerInfomationCache, BeastUtils.PlayerState> OnStateChange
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

		public event Action<OnlinePlayerInfomationCache, int> OnTeamChange
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

		public event Action<OnlinePlayerInfomationCache> OnCostumeChange
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

		public event Action<OnlinePlayerInfomationCache> OnColourChange
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

		public event Action<OnlinePlayerInfomationCache, Actor.Voice> OnVoiceChange
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

		public void Update(BeastInfo information)
		{
		}

		public void Destroy()
		{
		}

		public OnlinePlayerInfomationCache(int playerMaster, int controller)
		{
		}
	}
}
