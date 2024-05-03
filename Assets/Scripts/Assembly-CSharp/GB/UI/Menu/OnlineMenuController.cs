using System;
using CS.CorePlatform;
using UnityEngine;
using UnityEngine.Events;

namespace GB.UI.Menu
{
	public class OnlineMenuController : MenuController
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

		public void CreateLobby()
		{
		}

		private void CreateLobbyInternal()
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
