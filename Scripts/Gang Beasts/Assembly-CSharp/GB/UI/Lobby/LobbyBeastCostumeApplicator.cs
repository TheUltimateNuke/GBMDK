using CS.CorePlatform;
using Coatsink.Platform.Systems.User;
using GB.Platform.Lobby;
using GB.UI.Beasts;
using UnityEngine;

namespace GB.UI.Lobby
{
	public class LobbyBeastCostumeApplicator : BeastCostumeApplicatorBase
	{
		[SerializeField]
		protected InputMap _joinButton;

		[SerializeField]
		protected InputMap _leaveButton;

		private bool[] _wantsIn;

		private LocalPlayerInfomationCache _CachedLastPlayer;

		private bool _PromptActive;

		[SerializeField]
		private MenuHandlerGamemodes _matchMaker;

		[SerializeField]
		private LobbyState.Game _gameState;

		private new void OnEnable()
		{
		}

		private void LobbyPlayerManager_OnAllawanceChange(BaseUserInfo arg1, int arg2, bool arg3, OnlineID id)
		{
		}

		protected new void OnDisable()
		{
		}

		protected override bool OnInactive(LocalPlayerInfomationCache player)
		{
			return false;
		}

		private void InactiveJoin(LocalPlayerInfomationCache player)
		{
		}

		private void InactiveLeave(LocalPlayerInfomationCache player)
		{
		}

		protected override void applySubmit()
		{
		}

		protected override void applyCancel()
		{
		}

		protected override bool OnDesigning(LocalPlayerInfomationCache player)
		{
			return false;
		}

		private void DesigningJoin(LocalPlayerInfomationCache player)
		{
		}

		private void DesigningLeave(LocalPlayerInfomationCache player)
		{
		}

		protected override bool OnReady(LocalPlayerInfomationCache player)
		{
			return false;
		}

		private void ReadyLeave(LocalPlayerInfomationCache player)
		{
		}

		protected override void onLobbyStateChange(LocalPlayerInfomationCache player, LobbyState.State newState)
		{
		}

		protected override bool ForceExit()
		{
			return false;
		}

		private bool MainInGame()
		{
			return false;
		}

		protected override void OnExit()
		{
		}

		private void PlatformEvents_OnLobbyLeft()
		{
		}

		protected override bool IsCostumeChangeAllowed()
		{
			return false;
		}

		public override void ColourChange(LocalPlayerInfomationCache player, int change, bool freeOld = true)
		{
		}

		private void PlatformEvents_OnLocalUserChanged(int slot, int localuserID, bool joined)
		{
		}

		private void PlatformEvents_OnOnlineCheckCompleteEvent(int arg1, TryOnlineResult arg2)
		{
		}

		private bool LastActivePlayer()
		{
			return false;
		}

		private bool DebugKeyPressed(int id)
		{
			return false;
		}
	}
}
