using System;
using CS.CorePlatform;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace GB.UI.Lobby
{
	public class LobbyMovementHandler : MonoBehaviour
	{
		private enum Blocker
		{
			Checking = 0,
			Joined = 1,
			Created = 2,
			Leave = 3,
			None = 4
		}

		[Serializable]
		public class StringEvent : UnityEvent
		{
		}

		[SerializeField]
		private Blocker _type;

		public StringEvent Start;

		public StringEvent Fail;

		private bool _alreadyFailed;

		[SerializeField]
		private TextMeshProUGUI _infoText;

		[SerializeField]
		private bool _showAction;

		[SerializeField]
		private bool _showActionForWireless;

		[SerializeField]
		private string _actionCode;

		public StringEvent _actionEvents;

		[SerializeField]
		private bool _showCancel;

		[SerializeField]
		private string _cancelString;

		public StringEvent _cancelEvents;

		[SerializeField]
		private GameObject _loader;

		private void OnEnable()
		{
		}

		private void OnLobbyLeft()
		{
		}

		private void OnNoRoomForMe()
		{
		}

		private void PlatformFailedEvent(ErrorCode value)
		{
		}

		private void OnlineCheckComplete(int arg1, TryOnlineResult arg2)
		{
		}

		private bool ShowActionButton()
		{
			return false;
		}

		private void OnDisable()
		{
		}

		private void RunFail()
		{
		}

		private void OnSubmit(GBUIInputHandler arg1, BaseEventData arg2)
		{
		}

		private void OnCancel(GBUIInputHandler arg1, BaseEventData arg2)
		{
		}

		public void SetFailedFlag(bool value)
		{
		}
	}
}
