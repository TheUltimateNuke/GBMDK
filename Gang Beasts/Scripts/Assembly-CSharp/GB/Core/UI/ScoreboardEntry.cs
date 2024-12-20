using GB.Networking.Objects;
using GB.Platform.UI;
using UnityEngine;
using UnityEngine.UI;

namespace GB.Core.UI
{
	public class ScoreboardEntry : BoardEntry
	{
		[SerializeField]
		private RawImage IconPanel;

		[SerializeField]
		private Text NamePanel;

		[SerializeField]
		private Text PingPanel;

		private Texture2D _playerIcon;

		[SerializeField]
		private MicActiveIconHandler MicHandle;

		[HideInInspector]
		private bool _imageLoaded;

		[SerializeField]
		private Texture2D _fallbackIcon;

		public override void Initialise(int connID, int controllerID)
		{
		}

		public override void UpdateUI(NetBeast beast, NetPlatform platform, bool forceImageReload = false)
		{
		}
	}
}
