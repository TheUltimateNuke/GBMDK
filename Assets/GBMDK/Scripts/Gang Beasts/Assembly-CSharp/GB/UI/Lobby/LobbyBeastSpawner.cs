using CS.CorePlatform;
using Coatsink.Platform.Systems.User;
using GB.UI.Beasts;
using UnityEngine;

namespace GB.UI.Lobby
{
	public class LobbyBeastSpawner : MonoBehaviour
	{
		[SerializeField]
		private BeastMenuManager _beastManager;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void RefreshSpawns()
		{
		}

		private void LobbyPlayerManager_OnAllawanceChange(BaseUserInfo arg1, int arg2, bool arg3, OnlineID id)
		{
		}

		public void SpawnBeastFor(int playerID)
		{
		}
	}
}
