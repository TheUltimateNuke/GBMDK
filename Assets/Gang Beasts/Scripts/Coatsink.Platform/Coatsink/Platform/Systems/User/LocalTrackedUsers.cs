using System.Collections.Generic;

namespace Coatsink.Platform.Systems.User
{
	public class LocalTrackedUsers<T> : IUserManager where T : ITrackedUser, new()
	{
		protected object _locker;

		protected PlatformID _platform;

		private uint _onlineAllowedKey;

		protected LocalID _currentPrimary;

		protected int _platformMax;

		protected List<T> _activeUsers;

		public LocalID PrimaryUser => default(LocalID);

		public int MaxUsers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual int PlatformMaxUsers => 0;

		public LocalTrackedUsers(int maxUsers = 8, PlatformID platform = PlatformID.NONE, int platformMax = -1, bool allowOnline = false)
		{
		}

		public int GetControllerSlot(LocalID localID)
		{
			return 0;
		}

		public virtual string GetUserName(LocalID localID)
		{
			return null;
		}

		public UserInfo GetUserInfo(LocalID localID)
		{
			return default(UserInfo);
		}

		public virtual OnlineID GetUserOnlineID(LocalID localID)
		{
			return default(OnlineID);
		}

		public LocalID LocalID(int controller)
		{
			return default(LocalID);
		}

		public virtual LocalID LocalID(OnlineID onlineID)
		{
			return default(LocalID);
		}

		public virtual void OnlineAllowed(LocalID localID, bool showMessage, bool realtime, TaskResult<LocalID, bool> taskResult)
		{
		}

		public int SetPrimaryUser(LocalID localID)
		{
			return 0;
		}

		public virtual void UserJoin(int controller, TaskResult<LocalID, int> taskResult)
		{
		}

		protected virtual void UserJoin(int controller, TaskResult<LocalID, int> taskResult, params object[] info)
		{
		}

		public virtual int UserLeave(int controller)
		{
			return 0;
		}
	}
}
