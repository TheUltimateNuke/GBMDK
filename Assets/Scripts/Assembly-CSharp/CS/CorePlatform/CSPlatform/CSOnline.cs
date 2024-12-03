using System.Collections.Generic;
using CS.CorePlatform.Base.Client.Part;
using CS.CorePlatform.Utils.Data;
using Coatsink.Platform;
using Coatsink.Platform.Systems.Online;
using Coatsink.Platform.Systems.Online.Connections;
using Coatsink.Platform.Systems.User;
using Coatsink.Platform.Utils;

namespace CS.CorePlatform.CSPlatform
{
	public class CSOnline : BasePostBox<UserInfo>
	{
		private struct MessageQueue
		{
			public UserInfo target;

			public byte[] message;

			public uint size;

			public MessageQueue(UserInfo target, byte[] message, uint size)
			{
				this.target = default(UserInfo);
				this.message = null;
				this.size = 0u;
			}
		}

		private static int MAX_RECONNECTS;

		private static int MAX_RESEND_TRY;

		public static string JOINED_FOR_NONE_INITIAL_USERID;

		private const Debug.Level MESSAGE_LOG_LEVEL_INFO = Debug.Level.INFO | Debug.Level.SPAM;

		private const Debug.Level MESSAGE_LOG_LEVEL_WARN = Debug.Level.WARNING | Debug.Level.SPAM;

		private const Debug.Level MESSAGE_LOG_LEVEL_ERRO = Debug.Level.ERROR | Debug.Level.SPAM;

		private const Debug.Level MESSAGE_LOG_LEVEL_ERRO_RETRYFAIL = Debug.Level.ERROR | Debug.Level.DEEP;

		private int _connectionTrys;

		private int _sendTry;

		private bool _fullyJoined;

		private int skipCounter;

		private int eventCounter;

		private List<UserInfo> lobbyStatusCache;

		private List<BaseUserInfo> _connectedUsers;

		private List<UserInfo> _userInfoCache;

		private BaseUserInfo _host;

		private BaseUserInfo _localInfo;

		private PlatformMessageBase _kickMessage;

		private LocalID _wantedUser;

		private ILobbyID _wantedLobby;

		private TaskResult<ILobby> _inviteQueue;

		private CSUserEvents _userEvents;

		private ITaskResult _currentTask;

		private ILobby _currentLobby;

		private LobbyTransporter _lobbyMessages;

		private object _sendLocker;

		private Queue<MessageQueue> _waitingMessages;

		public ILobbyID CurrentLobbyID => null;

		public bool IsInLobby => false;

		public bool IsLobbyHost => false;

		public bool IsJoiningLobby => false;

		public bool HasLobbyInvite => false;

		public int TotalInLobby => 0;

		private ILobby CurrentLobby
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CSOnline(CSUserEvents userEvents)
		{
		}

		~CSOnline()
		{
		}

		private void CheckFullyJoined()
		{
		}

		private void CheckConnected(UserInfo user, bool checkFully = true)
		{
		}

		private void OnUserLeft(ILobby lobby, UserInfo user)
		{
		}

		private void OnUserJoin(ILobby lobby, UserInfo user)
		{
		}

		private void OnLobbyClosed(ILobby lobby, ILobbyID lobbyId)
		{
		}

		private void OnHostChanged(ILobby lobby, UserInfo user)
		{
		}

		public void CheckForStartupInvite()
		{
		}

		public void CheckSetup()
		{
		}

		private void OnInviteAccepted(LocalID wantedUser, ILobbyID lobbyId)
		{
		}

		private void OnPlatformWantsLobbyCreated(LocalID arg1, TaskResult<ILobby> arg2)
		{
		}

		public void CreateLobby(LOBBY_TYPE lobbyType, uint maxSlots)
		{
		}

		private void OnCreatedLobby(TaskResult<ILobby> obj)
		{
		}

		public void JoinLobby(ILobbyID id)
		{
		}

		private void OnJoinedLobby(TaskResult<ILobby> obj)
		{
		}

		public void LeaveLobby()
		{
		}

		public bool UserIsInLobby(BaseUserInfo user)
		{
			return false;
		}

		public bool UserIsLobbyHost(BaseUserInfo user)
		{
			return false;
		}

		public BaseUserInfo LobbyHost()
		{
			return default(BaseUserInfo);
		}

		public bool GetLobbyInfo(ref LobbyInformation lobbyInfo)
		{
			return false;
		}

		public bool GetLobbyUser(int index, ref BaseUserInfo userData)
		{
			return false;
		}

		public bool GetLobbyUser(OnlineID userID, ref BaseUserInfo userData)
		{
			return false;
		}

		public bool LobbyKickUser(BaseUserInfo info)
		{
			return false;
		}

		public bool ShowPlatformLobbyMenu()
		{
			return false;
		}

		public bool KickUser(BaseUserInfo info)
		{
			return false;
		}

		public void UseBeenKickedMessage(UserInfo senderID)
		{
		}

		public bool UserIsInLobby(UserInfo userID, ref BaseUserInfo user)
		{
			return false;
		}

		public bool SendLobbyMessage(BaseUserInfo userInfo, PlatformMessageBase message)
		{
			return false;
		}

		public bool SendLobbyMessage(PlatformMessageBase message)
		{
			return false;
		}

		public bool MessageConnectionReady(BaseUserInfo userInfo)
		{
			return false;
		}

		public override void SendNewMessage(UserInfo userID, byte[] message, int size, bool reliable)
		{
		}

		private void SendWaitingMessages()
		{
		}

		protected override bool GetMessage(ref UserInfo senderID, out DataReader message)
		{
			message = null;
			return false;
		}

		protected override void ParseMessage(UserInfo senderID, DataReader message)
		{
		}

		public string LobbyStatus()
		{
			return null;
		}
	}
}
