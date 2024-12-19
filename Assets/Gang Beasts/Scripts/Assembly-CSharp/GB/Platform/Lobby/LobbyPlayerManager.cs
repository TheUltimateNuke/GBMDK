using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CS.CorePlatform;
using Coatsink.Platform.Systems.User;
using GB.Platform.Lobby.Messages;
using UnityEngine;

namespace GB.Platform.Lobby
{
	public class LobbyPlayerManager : LobbyPart
	{
		public enum Permission
		{
			Out = 0,
			Requesting = 1,
			In = 2,
			Leaving = 3
		}

		public class AllowanceCarrier
		{
			private int _playerID;

			private Permission[] _totalAllowedPlayers;

			private string[] _names;

			private OnlineID[] _ids;

			private int _joinedCached;

			public int PlayerID => 0;

			public int TotalAllowed => 0;

			public int TotalJoined => 0;

			public AllowanceCarrier(int PlayerID, int Max)
			{
			}

			public int IDController(OnlineID id)
			{
				return 0;
			}

			public bool HasPlayerID(int playerID)
			{
				return false;
			}

			public Permission GetAllowedPlayerID(int playerID)
			{
				return default(Permission);
			}

			public Permission GetAllowed(int controller)
			{
				return default(Permission);
			}

			public bool SetAllowed(int controller, Permission value, string name, OnlineID id)
			{
				return false;
			}

			public int GetNumber(int controller)
			{
				return 0;
			}

			public string GetName(int controller)
			{
				return null;
			}

			public OnlineID GetOnlineID(int controller)
			{
				return default(OnlineID);
			}
		}

		private BasePlatformManager _managerCache;

		private Dictionary<BaseUserInfo, AllowanceCarrier> _playerAllowance;

		private int _totalCache;

		private string _leaveReason;

		private int _maxAllawed;

		private JoinRequest _joinMessage;

		private JoinUpdate _joinUpdate;

		private JoinRequest _kickMessage;

		private LobbySnapshot _lobbyPlayerStates;

		private bool _drawInspector;

		public int TotalCache => 0;

		public string LeaveReason
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int MaxAllawed
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static event Action<int> OnMeJoined
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

		public static event Action<BaseUserInfo, int, bool, OnlineID> OnAllawanceChange
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

		public static event Action<BaseUserInfo, int> OnPlayerJoined
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

		public static event Action<BaseUserInfo, int> OnPlayerAllowed
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

		public static event Action<BaseUserInfo> OnPlayerLeft
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

		public static event Action OnNoRoomForMe
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

		private void RecievedCompleteLobbyStateRequest(BaseUserInfo arg1, JoinRequest arg2)
		{
		}

		public void UpdateMessageUserInfo()
		{
		}

		public override void ClearData()
		{
		}

		private void OnDestroy()
		{
		}

		private void PlatformEvents_OnLobbyNewHostEvent(BaseUserInfo info)
		{
		}

		private void PlatformEvents_OnLobbyUserJoinedEvent(BaseUserInfo info)
		{
		}

		private void PlatformEvents_OnLobbyUserLeftEvent(BaseUserInfo info)
		{
		}

		private void RecievedJoinRequest(BaseUserInfo user, JoinRequest message)
		{
		}

		private bool TryJoin(JoinRequest message)
		{
			return false;
		}

		private void ResendAllPermits(BaseUserInfo user, LobbyMessage message)
		{
		}

		private void OnUpdateRecieved(BaseUserInfo user, JoinUpdate message)
		{
		}

		private void SendLobbySnapshot(BaseUserInfo wantsUpdate)
		{
		}

		private void RecievedCompleteState(BaseUserInfo user, LobbySnapshot message)
		{
		}

		private void RecievedJoinPermited(BaseUserInfo user, JoinRequest message)
		{
		}

		private void PermissionChanged(BaseUserInfo user, int controller, bool allowed, string name, string reason, OnlineID id)
		{
		}

		private int FindUnusedPlayerID()
		{
			return 0;
		}

		public void RequestSlot(int playerID, bool join, bool forceSend = false)
		{
		}

		public Permission GetPermission(BaseUserInfo user, int controller)
		{
			return default(Permission);
		}

		public Permission GetPermission(int playerID)
		{
			return default(Permission);
		}

		public bool GetPermission(BaseUserInfo user)
		{
			return false;
		}

		public bool IAmIn()
		{
			return false;
		}

		public Dictionary<BaseUserInfo, AllowanceCarrier>.Enumerator GetPlayerEnumer()
		{
			return default(Dictionary<BaseUserInfo, AllowanceCarrier>.Enumerator);
		}

		public int GetPlayerCount()
		{
			return 0;
		}

		public int GetBeastCount()
		{
			return 0;
		}

		public int GetPlayerNumber(BaseUserInfo user, int controller)
		{
			return 0;
		}

		public int GetPlayerMain(BaseUserInfo user)
		{
			return 0;
		}

		public string GetPlayerName(BaseUserInfo user, int controller)
		{
			return null;
		}

		public OnlineID GetPlayerOnlineID(BaseUserInfo user, int controller)
		{
			return default(OnlineID);
		}

		public int GetPlayerID(BaseUserInfo user)
		{
			return 0;
		}

		public List<int> GetPlayerControllers(BaseUserInfo user)
		{
			return null;
		}

		public void KickUser(BaseUserInfo user, int controllerID)
		{
		}

		public override void DrawInspector()
		{
		}
	}
}
