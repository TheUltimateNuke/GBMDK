using System.Collections.Generic;
using CS.CorePlatform;
using UnityEngine;
using UnityEngine.UI;

namespace GB.Platform.UI.Lobby
{
	public class LobbyUserTextElement : MonoBehaviour
	{
		public BaseUserInfo userInfo;

		private bool _isHost;

		[SerializeField]
		public Selectable selectable;

		[SerializeField]
		private GameObject hostImage;

		[SerializeField]
		private RawImage avatarImage;

		[SerializeField]
		private Text userName;

		private Texture2D avatarTexture;

		[SerializeField]
		private MicActiveIconHandler micIcon;

		[SerializeField]
		private GameObject guestBase;

		[SerializeField]
		private GameObject guestParent;

		private List<GameObject> guestList;

		public int TotalGuests
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void SetUpElement()
		{
		}

		public void SetHostIcon(BaseUserInfo hostInfo)
		{
		}

		public void SetHostIcon(bool toThis)
		{
		}

		public void KickMe()
		{
		}
	}
}
