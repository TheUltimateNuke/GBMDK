using System.Collections.Generic;
using Coatsink.Platform;
using Coatsink.Platform.Systems.User;

namespace CS.CorePlatform.CSPlatform
{
	public abstract class CSUserEvents
	{
		protected class UserCarrier
		{
			public bool checking;

			public int controller;

			public TryOnlineResult state;
		}

		protected Dictionary<LocalID, UserCarrier> _users;

		protected ITaskResult _currentTask;

		protected bool _signingIn;

		protected LocalID _cachedMain;

		protected bool CurrentlyWorking => false;

		public CSUserEvents()
		{
		}

		protected void OnPrimaryLost(LocalID obj)
		{
		}

		protected virtual void OnUserLeft(LocalID obj)
		{
		}

		~CSUserEvents()
		{
		}

		public abstract void ClearMain();

		public abstract bool UserJoined(int controller);

		public abstract void UserLeave(int controller);

		public abstract void UpdateOnlinePermistion(int controller = -1);

		public abstract TryOnlineResult TryToGoOnline(bool showMessage);

		public abstract TryOnlineResult TryToGoOnline(int controller, bool showMessage);

		public abstract bool ShowOnlineFailReason(int controller);

		public abstract void OnAllowedComplete(TaskResult<LocalID, bool> obj);

		public TaskResult<LocalID, bool> CheckMainUser(bool showmessage = false)
		{
			return null;
		}

		public virtual void SetPlayedWith(UserInfo userInfo)
		{
		}

		public abstract string DebugDataInfo();
	}
}
