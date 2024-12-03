using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Coatsink.Platform.Systems.Online;
using Coatsink.Platform.Systems.User;
using Steamworks;

namespace Coatsink.Platform.Steam
{
	public class Lobby : ILobby
	{
		private bool _joinable;

		private Func<bool> _steamCheck;

		private LobbyLongID _currentLobby;

		private object _locker;

		private TaskResult<ILobby> _activeTask;

		protected Callback<LobbyCreated_t> _callbackOnLobbyCreated;

		protected Callback<LobbyEnter_t> _callbackOnLobbyJoined;

		protected Callback<LobbyChatUpdate_t> _callbackOnLobbyUpdated;

		private bool _inLobby;

		private bool _isHost;

		private UserInfo _hostID;

		private List<UserInfo> _currentMembers;

		public ILobbyID LobbyID => null;

		public UserInfo Host => default(UserInfo);

		public bool IsInLobby => false;

		public bool IsLobbyHost => false;

		public bool IsJoiningLobby => false;

		public int TotalInLobby => 0;

		public bool Joinable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event LobbyUserEvent OnUserLeft
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

		public event LobbyUserEvent OnUserJoin
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

		public event LobbyUserEvent OnHostChanged
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

		public event LobbyIdEvent OnLobbyClosed
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

		public Lobby(Func<bool> steamCheck)
		{
		}

		~Lobby()
		{
		}

		public TaskResult<ILobby> CreateLobby(LocalID join, uint maxSlots, TaskResult<ILobby> task = null)
		{
			return null;
		}

		private void OnLobbyCreated(LobbyCreated_t obj)
		{
		}

		public TaskResult<ILobby> JoinLobby(LocalID join, ILobbyID id, TaskResult<ILobby> task = null)
		{
			return null;
		}

		private void OnLobbyEntered(LobbyEnter_t obj)
		{
		}

		private void RefreshLobbyInfo()
		{
		}

		private void OnLobbyUpdated(LobbyChatUpdate_t obj)
		{
		}

		private void CheckHost()
		{
		}

		public TaskResult<ILobby> LeaveLobby(TaskResult<ILobby> task = null)
		{
			return null;
		}

		private void ClearLobby()
		{
		}

		public uint GetLobbyUsers(ref List<UserInfo> users)
		{
			return 0u;
		}

		public string GetUserName(UserInfo userInfo)
		{
			return null;
		}

		public TaskResult<ILobby> ShowInviteUI(LocalID localID, int maxInvites, TaskResult<ILobby> taskResult = null)
		{
			return null;
		}
	}
}
