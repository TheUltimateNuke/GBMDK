using CS.CorePlatform;
using Coatsink.Platform.Systems.User;
using GB.Platform.Lobby.Messages;
using GB.UI.Beasts;

namespace GB.Platform.Lobby
{
	public class LocalBeastMessageSender : LobbyPart
	{
		private BeastInfoMesssage[] _beastMessages;

		private BasePlatformManager _platformCache;

		private LobbyPlayerManager _players;

		private void Awake()
		{
		}

		private void OnCostumePoolLoaded()
		{
		}

		private void OnDestroy()
		{
		}

		private void SendCostumes(BaseUserInfo user, LobbyMessage message)
		{
		}

		public void SendCostumes()
		{
		}

		public void SendCostume(int playerID)
		{
		}

		private void OnAllawanceChange(BaseUserInfo arg1, int arg2, bool arg3, OnlineID id)
		{
		}

		private void OnTeamChange(LocalPlayerInfomationCache arg1, int arg2)
		{
		}

		private void StateChange(LocalPlayerInfomationCache arg1, BeastUtils.PlayerState arg2)
		{
		}

		private void CostumeChange(LocalPlayerInfomationCache arg1, int arg2)
		{
		}

		private void ColourChange(LocalPlayerInfomationCache arg1, int arg2)
		{
		}
	}
}
