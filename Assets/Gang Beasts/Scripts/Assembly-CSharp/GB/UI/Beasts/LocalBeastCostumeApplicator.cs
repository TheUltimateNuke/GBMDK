using System;
using GB.Platform.Lobby;
using UnityEngine;
using UnityEngine.Events;

namespace GB.UI.Beasts
{
	public class LocalBeastCostumeApplicator : BeastCostumeApplicatorBase
	{
		[Serializable]
		public class StringEvent : UnityEvent
		{
		}

		[SerializeField]
		protected InputMap _joinButton;

		[SerializeField]
		protected InputMap _leaveButton;

		public Action<float> OnCountdownChanged;

		public StringEvent Exit;

		[SerializeField]
		private StartGameCountdown _countdown;

		private int ActivePlayerCount => 0;

		protected new void OnEnable()
		{
		}

		protected override void applySubmit()
		{
		}

		protected override void applyCancel()
		{
		}

		private void LocalBeastStateChange(LocalPlayerInfomationCache arg1, BeastUtils.PlayerState arg2)
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

		protected void ClearBeastData()
		{
		}

		protected override void OnExit()
		{
		}

		private bool LastActivePlayer()
		{
			return false;
		}

		public override void ColourChange(LocalPlayerInfomationCache player, int change, bool freeOld = true)
		{
		}

		protected override void onLobbyStateChange(LocalPlayerInfomationCache player, LobbyState.State newState)
		{
		}

		protected override bool IsCostumeChangeAllowed()
		{
			return false;
		}
	}
}
