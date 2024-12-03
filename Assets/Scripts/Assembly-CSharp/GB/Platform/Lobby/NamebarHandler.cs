using System;
using CS.CorePlatform;
using Coatsink.Platform.Systems.User;
using GB.Platform.UI;
using GB.UI.Beasts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GB.Platform.Lobby
{
	public class NamebarHandler : MonoBehaviour
	{
		[Serializable]
		private struct PingSetter
		{
			public int number;

			public GameObject images;

			public PingSetter(int _number, GameObject _images)
			{
				number = 0;
				images = null;
			}
		}

		[SerializeField]
		private PingSetter[] _pingLevels;

		[SerializeField]
		private GameObject _hostImage;

		[SerializeField]
		private TextMeshProUGUI _nameBar;

		[SerializeField]
		private Text _nameBarFallback;

		[SerializeField]
		private GameObject _joinSign;

		[SerializeField]
		private GameObject _uiController;

		[SerializeField]
		private Collider _collider;

		[SerializeField]
		private BeastMenuManager _beastManager;

		[SerializeField]
		private int _pointID;

		private int _controllerID;

		private int _playerID;

		private BaseUserInfo _currentUser;

		private int _controllerCounter;

		[SerializeField]
		public MicActiveIconHandler CachedMicIcon;

		public Collider Area => null;

		public int PlayerID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Graphic NameGraphic => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void UIControllerChange()
		{
		}

		private void OnAllawanceChange(BaseUserInfo arg1, int arg2, bool arg3, OnlineID id)
		{
		}

		private void PlayerPositionChange(int point, int playerID)
		{
		}

		private void UpdateLobbyVoip(BaseUserInfo arg1, int controllerID, bool arg2)
		{
		}

		private void UpdatePing(BaseUserInfo arg1, int value)
		{
		}

		private void NewHost(BaseUserInfo info)
		{
		}

		private void UpdateNamebar()
		{
		}

		private void ShowPlayerInfo()
		{
		}

		private void ShowJoinInfo()
		{
		}

		private void DisableAllOnlineInfo()
		{
		}
	}
}
