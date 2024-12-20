using CS.CorePlatform;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GB.UI
{
	public class PlayerListButton : MonoBehaviour
	{
		private BaseUserInfo _userTarget;

		private int _userController;

		private int _userCounter;

		private int _connectionID;

		private bool _voiceActive;

		[SerializeField]
		private TextMeshProUGUI _text;

		[SerializeField]
		private GameObject _talking;

		[SerializeField]
		private GameObject _muted;

		[SerializeField]
		private Selectable _uiNavigation;

		public BaseUserInfo UserTarget
		{
			get
			{
				return default(BaseUserInfo);
			}
			set
			{
			}
		}

		public int UserController
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int UserCounter
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ConnectionID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Selectable UINav => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetColour(Color colour)
		{
		}

		public void SetText(string text)
		{
		}

		public void ToggleMute()
		{
		}

		public void ShowInfo()
		{
		}

		private void PlatformEvents_OnVoiceMuteStateChangedEvent(BaseUserInfo info, bool effect)
		{
		}

		public void UpdateVoiceChat(bool active)
		{
		}
	}
}
