using Coatsink.Platform.Systems.UI;
using Coatsink.Platform.Systems.User;
using Steamworks;

namespace Coatsink.Platform.Steam
{
	public class UIPlatformManager : IUIPlatformManager
	{
		private readonly object _locker;

		private readonly Callback<GameOverlayActivated_t> _callbackOverlayChanged;

		private bool _overlayActive;

		public bool Active => false;

		~UIPlatformManager()
		{
		}

		public uint OpenUserProfile(LocalID localID, UserInfo onlineUser)
		{
			return 0u;
		}

		private void OnOverlayChanged(GameOverlayActivated_t overlayEffect)
		{
		}
	}
}
