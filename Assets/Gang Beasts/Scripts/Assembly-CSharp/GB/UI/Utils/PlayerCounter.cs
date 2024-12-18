using CS.CorePlatform;
using Coatsink.Platform.Systems.User;
using GB.Platform.Lobby;
using GB.UI.Beasts;
using TMPro;
using UnityEngine;

namespace GB.UI.Utils
{
	public class PlayerCounter : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _textField;

		private LobbyManager _lobbyCache;

		private LobbyManager Lobby => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateInfo()
		{
		}

		private void LocalBeastSetupTracker_OnStateChange(LocalPlayerInfomationCache arg1, BeastUtils.PlayerState arg2)
		{
		}

		private void LobbyPlayerManager_OnAllawanceChange(BaseUserInfo arg1, int arg2, bool arg3, OnlineID id)
		{
		}
	}
}
