using System;
using System.Collections.Generic;
using CS.CorePlatform;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GB.UI.Menu
{
	public class WirelessModeMenuController : MenuController
	{
		[Serializable]
		public class StringEvent : UnityEvent
		{
		}

		private struct RoomsAndPlayers
		{
			public Button roomButton;

			public TextMeshProUGUI roomText;

			public TextMeshProUGUI playersPerRoomText;

			public void Enable(bool enable)
			{
			}
		}

		[SerializeField]
		private StringEvent _exit;

		[SerializeField]
		private UnityEvent OnReady;

		[SerializeField]
		private Button _createButton;

		[SerializeField]
		private TextMeshProUGUI _searchingText;

		private const int ROOM_COUNT = 2;

		private List<RoomsAndPlayers> _roomsAndPlayers;

		private List<LobbyInformation> lobbyInfo;

		private void FillRoomsAndPlayersList()
		{
		}

		private void UpdateUI()
		{
		}

		public void GatherLobbies()
		{
		}

		public void JoinLobby(int index)
		{
		}

		public new void OnEnable()
		{
		}

		private void Enable()
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

		public void Close()
		{
		}
	}
}
