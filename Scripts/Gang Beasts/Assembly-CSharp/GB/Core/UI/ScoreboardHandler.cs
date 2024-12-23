using System.Collections.Generic;
using CS.CorePlatform;
using CoreNet.Objects;
using GB.Networking.Objects;
using GB.View.UI;
using UnityEngine;

namespace GB.Core.UI
{
	public class ScoreboardHandler : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _layoutParent;

		private List<BoardEntry> _activeEntries;

		private AnimFloat _AnimFloat;

		private CanvasGroup scoreboardCanvas;

		private UIController uiController;

		[SerializeField]
		private GameObject _BaseEntry;

		private bool scoreboardVisible;

		public void Start()
		{
		}

		public void OnDestroy()
		{
		}

		private void UpdatedPlaylistLength(NetInt playlistLength)
		{
		}

		private void Update()
		{
		}

		public void SetScoreboardVisible(bool makeVisible, float duration = 0.15f)
		{
		}

		private void OnClientStopped()
		{
		}

		private void OnPlayerAdded(NetBeast beast)
		{
		}

		private void OnPlayerUpdated(NetBeast beast)
		{
		}

		private void OnPlayerRemoved(NetBeast beast)
		{
		}

		private void OnPlatformAddedOrUpdated(NetPlatform platform)
		{
		}

		private void OnPlatformRemoved(NetPlatform platform)
		{
		}

		private void UpdateUI(NetBeast beast, NetPlatform platform = null, bool forceImageReload = false)
		{
		}

		private void OnUserImageLoaded(BaseUserInfo userInfo)
		{
		}
	}
}
