using System;
using System.Collections.Generic;
using CS.CorePlatform;
using GB.Platform.Lobby.Messages;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GB.UI.Menu
{
	public class WirelessMenuController : MenuController
	{
		[Serializable]
		public class StringEvent : UnityEvent
		{
		}

		[SerializeField]
		private StringEvent _exit;

		[SerializeField]
		private BaseMenuScreen defaultClientScreen;

		[SerializeField]
		private BaseMenuScreen defaultHostScreen;

		[SerializeField]
		private BaseMenuScreen[] _hostScreens;

		[SerializeField]
		private BaseMenuScreen[] _clientScreens;

		[SerializeField]
		private Button _startButton;

		private List<LobbyInformation> lobbyInfo;

		private List<BaseUserInfo> _usersReady;

		private float _nextUpdateTime;

		private float _nextUpdateDelta;

		public void CreateLobby()
		{
		}

		public void JoinLobby(int index)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void LobbyNewHost(BaseUserInfo info)
		{
		}

		private void OnPlayerLeft(BaseUserInfo user)
		{
		}

		private void ReadyToJoin(BaseUserInfo arg1, ClientReadyToJoinMessage arg2)
		{
		}

		private void Update()
		{
		}

		private bool ScreenAllowedCheck(BaseMenuScreen check)
		{
			return false;
		}

		public new void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void GoToRoot()
		{
		}

		public new void Start()
		{
		}

		public new void PushScreen(BaseMenuScreen screen)
		{
		}

		public new void PopScreen()
		{
		}

		public void Close()
		{
		}
	}
}
