using CoreNet.Objects;
using GB.Networking.Objects;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GB.Gamemodes
{
	public class ScoreDisplay : MonoBehaviour
	{
		public GameModeEnum supportedGameModes;

		public int gangID;

		private TextMeshProUGUI textRef;

		private bool active;

		private bool visible;

		private void Start()
		{
		}

		private void RegisterForMessages()
		{
		}

		private void RegisterWithModel()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnSceneChange(Scene prev, Scene next)
		{
		}

		private void OnModeChange(NetString newMode)
		{
		}

		private void OnNetGangAdded(NetGang gang)
		{
		}

		private void OnNetGangUpdated(NetGang gang)
		{
		}

		private void OnNetGangRemoved(NetGang gang)
		{
		}

		public void Deactivate()
		{
		}

		private void OnLoadingScreenShown()
		{
		}

		private void OnLoadingScreenHidden()
		{
		}

		private void PauseHandler()
		{
		}
	}
}
