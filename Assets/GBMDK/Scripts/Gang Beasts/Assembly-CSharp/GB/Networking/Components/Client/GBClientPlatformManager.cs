using CoreNet.Components;
using CoreNet.Objects;
using GB.Networking.Messages;
using GB.Networking.Objects;
using UnityEngine.Networking;

namespace GB.Networking.Components.Client
{
	public class GBClientPlatformManager : NetComponent
	{
		private bool _wantsToLeave;

		private bool _leaving;

		private bool _gameSetup;

		private new void Awake()
		{
		}

		private void PlatformEvents_OnSendServerInfoUpdate(byte[] arg1, int arg2)
		{
		}

		private void OnPlatformServerUpdate(NetData item)
		{
		}

		private void OnAchievementUnlocked(NetAchievementMessage message, NetworkConnection conn)
		{
		}

		private void OnDestroy()
		{
		}

		private void OnServerConnectionSet(NetConnection connection)
		{
		}

		private void BeastUpdate(NetBeast beast)
		{
		}

		private void BeastNothing(NetBeast beast)
		{
		}

		private void GBClientGameRoundEventHandler_RoundStartEvent()
		{
		}

		private void GBClientGameRoundEventHandler_GameEndEvent()
		{
		}

		private void LobbyJoinedEvent()
		{
		}

		private void Quit()
		{
		}

		private void LoadScreenHidden()
		{
		}
	}
}
