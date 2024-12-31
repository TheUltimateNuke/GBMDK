using GB.UI.Lobby;
using UnityEngine;
using UnityEngine.UI;

namespace GB.UI.Online
{
	public class DirectConnectScript : MonoBehaviour
	{
		public Text ConnectIPInputField;

		public Text ConnectPortInputField;

		[SerializeField]
		private LobbyCountdown _countdown;

		public void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void StartDirectConnecting()
		{
		}

		public void DirectConnect()
		{
		}
	}
}
