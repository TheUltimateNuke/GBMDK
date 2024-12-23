using Coatsink.Platform;
using Coatsink.Platform.Systems.User;

namespace CS.CorePlatform.CSPlatform
{
	public class CSDynamicUserEvents : CSUserEvents
	{
		private int _joiningController;

		public override void ClearMain()
		{
		}

		public override void UserLeave(int controller)
		{
		}

		public override bool UserJoined(int controller)
		{
			return false;
		}

		private void OnUserJoined(TaskResult<LocalID, int> obj)
		{
		}

		public TaskResult<LocalID, bool> StartCheckingUser(LocalID local, bool showmessage = false)
		{
			return null;
		}

		public override void UpdateOnlinePermistion(int controller = -1)
		{
		}

		public override void OnAllowedComplete(TaskResult<LocalID, bool> obj)
		{
		}

		public override TryOnlineResult TryToGoOnline(bool showMessage)
		{
			return default(TryOnlineResult);
		}

		public override TryOnlineResult TryToGoOnline(int controller, bool showMessage)
		{
			return default(TryOnlineResult);
		}

		public override bool ShowOnlineFailReason(int controller)
		{
			return false;
		}

		public override string DebugDataInfo()
		{
			return null;
		}
	}
}
