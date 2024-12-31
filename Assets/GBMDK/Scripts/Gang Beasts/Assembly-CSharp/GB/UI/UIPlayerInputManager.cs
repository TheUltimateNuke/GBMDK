using System.Collections.Generic;
using GB.Platform.Lobby;
using GB.UI.Beasts;
using UnityEngine;
using UnityEngine.Events;

namespace GB.UI
{
	public class UIPlayerInputManager : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent OnReady;

		[SerializeField]
		private UnityEvent OnUnready;

		[SerializeField]
		private bool _multiMasters;

		private int _uiMaster;

		private List<int> _uiMasterList;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void StateChanged(LocalPlayerInfomationCache player, BeastUtils.PlayerState state)
		{
		}

		public void CheckUIInputAllowed(bool forceEvent = false)
		{
		}

		public void ResendOnReady()
		{
		}
	}
}
