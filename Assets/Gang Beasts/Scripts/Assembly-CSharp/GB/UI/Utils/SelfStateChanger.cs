using GB.Platform.Lobby;
using UnityEngine;

namespace GB.UI.Utils
{
	public class SelfStateChanger : MonoBehaviour
	{
		[SerializeField]
		private LobbyState.Game _setTo;

		private void OnEnable()
		{
		}
	}
}
