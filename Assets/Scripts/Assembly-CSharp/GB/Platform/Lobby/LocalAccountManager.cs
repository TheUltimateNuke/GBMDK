using CS.CorePlatform;
using Coatsink.Platform.Systems.User;
using GB.UI.Beasts;

namespace GB.Platform.Lobby
{
	public class LocalAccountManager : LobbyPart
	{
		private int[] _lockedBeasts;

		private bool _drawInspector;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void PlatformPermissionChanged(int slot, int localuserID, bool allowed)
		{
		}

		private void LobbyPermissionChanged(BaseUserInfo user, int controllerId, bool arg3, OnlineID id)
		{
		}

		private void ControllerOwnerChanged(int slot, int localuserID, bool joined)
		{
		}

		public void KickLocalPlayer(int slot)
		{
		}

		private void LocalBeastTaken(LocalPlayerInfomationCache arg1, BeastUtils.PlayerState arg2)
		{
		}

		public override void ClearData()
		{
		}

		public void ForceAllTo(int id = -1)
		{
		}

		public override void DrawInspector()
		{
		}
	}
}
