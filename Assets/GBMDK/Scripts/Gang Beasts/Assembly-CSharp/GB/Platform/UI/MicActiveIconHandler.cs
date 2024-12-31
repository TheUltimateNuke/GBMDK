using CS.CorePlatform;
using GB.Networking.Objects;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GB.Platform.UI
{
	public class MicActiveIconHandler : MonoBehaviour
	{
		private bool _voipActive;

		private int _controllerID;

		private BaseUserInfo targetUser;

		private int _connectionID;

		private BaseUserInfo _trueTarget;

		[SerializeField]
		private RawImage imageTarget;

		[SerializeField]
		private Texture2D imageActive;

		[SerializeField]
		private Texture2D imageMuted;

		[SerializeField]
		private bool lobbyPlatformVoip;

		public bool VoIPActive => false;

		public int Controller
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public BaseUserInfo TargetUser
		{
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

		private void ForceUpdate()
		{
		}

		private bool GetUserActive()
		{
			return false;
		}

		public void Awake()
		{
		}

		private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		private void PlatformEvents_OnVoiceEnabledStateChangedEvent(bool active)
		{
		}

		public void OnDestroy()
		{
		}

		public void BlankTarget()
		{
		}

		private void PlatformEvents_OnVoiceMuteStateChangedEvent(BaseUserInfo info, bool effect)
		{
		}

		private void NothingChat(NetChat chat)
		{
		}

		private void OnNetChatUpdate(NetChat chat)
		{
		}

		private void ChangeIcon(Texture2D image)
		{
		}

		private void PlatformLobbyManager_OnLobbyVoipChange(BaseUserInfo user, int controller, bool value)
		{
		}

		private void SetMicImageEnabled(bool enabled)
		{
		}
	}
}
