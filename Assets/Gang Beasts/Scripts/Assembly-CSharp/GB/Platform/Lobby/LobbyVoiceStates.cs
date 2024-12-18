using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CS.CorePlatform;
using GB.Platform.Lobby.Messages;

namespace GB.Platform.Lobby
{
	public class LobbyVoiceStates : LobbyPart
	{
		private Dictionary<BaseUserInfo, List<bool>> _activeMics;

		private BoolListMessage _voipMessage;

		public static event Action<BaseUserInfo, int, bool> OnStateChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public override void ClearData()
		{
		}

		private void OnPlayerJoined(BaseUserInfo arg1, int arg2)
		{
		}

		private void OnPlayerLeft(BaseUserInfo user)
		{
		}

		public bool GetVoiceState(BaseUserInfo user, int controller)
		{
			return false;
		}

		private void OnVoiceRecieved(BaseUserInfo arg1, BoolListMessage arg2)
		{
		}

		private void OnVoiceRequested(BaseUserInfo arg1, LobbyMessage arg2)
		{
		}

		private void PlatformEvents_OnVoiceMicChangeEvent(bool arg1, int arg2)
		{
		}

		public void SendVoice()
		{
		}

		public override void DrawInspector()
		{
		}
	}
}
