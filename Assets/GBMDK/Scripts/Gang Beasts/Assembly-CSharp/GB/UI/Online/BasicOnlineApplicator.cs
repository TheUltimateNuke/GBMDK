using System;
using System.Runtime.CompilerServices;
using GB.Gamemodes;
using GB.UI.Lobby;
using UnityEngine;
using UnityEngine.Events;

namespace GB.UI.Online
{
	public class BasicOnlineApplicator : MonoBehaviour
	{
		[Serializable]
		public class StringEvent : UnityEvent
		{
		}

		public enum Setting
		{
			None = 0,
			GameMode = 1,
			MaxPlayers = 2
		}

		[Serializable]
		private struct GamemodeInfo
		{
			[SerializeField]
			private GameModeEnum _gameMode;

			[SerializeField]
			private int _maxPlayers;

			public GameModeEnum GameMode => default(GameModeEnum);

			public int MaxPlayers => 0;

			public GamemodeInfo(GameModeEnum mode, int players)
			{
				_gameMode = default(GameModeEnum);
				_maxPlayers = 0;
			}
		}

		public StringEvent StartQuickMatch;

		[SerializeField]
		private LobbyCountdown _countdownHandler;

		[SerializeField]
		private float _countdownTime;

		[SerializeField]
		private GamemodeInfo[] _gameModes;

		private int _settingMode;

		public GameModeEnum EnumMode => default(GameModeEnum);

		public int GameMode
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string ModeName => null;

		public int MaxPlayers => 0;

		public event Action<Setting> OnSettingChanged
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

		public event Action OnPreGameStart
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

		private void Awake()
		{
		}

		public void ChangeValue(Setting setting, int amount)
		{
		}

		public string GetValueString(Setting setting)
		{
			return null;
		}

		public void BeginCountdown()
		{
		}

		private void BeginSearching()
		{
		}
	}
}
