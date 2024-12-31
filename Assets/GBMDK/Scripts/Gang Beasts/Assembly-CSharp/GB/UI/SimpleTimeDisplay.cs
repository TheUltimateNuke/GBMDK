using GB.Networking.Messages;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace GB.UI
{
	public class SimpleTimeDisplay : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI textRef;

		private int timer;

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

		private void Update()
		{
		}

		private void PauseHandler()
		{
		}

		private void OnLoadingScreenShown()
		{
		}

		private void OnLoadingScreenHidden()
		{
		}

		public void Deactivate()
		{
		}

		public void SetTimestamp(NetTimerMessage message, NetworkConnection conn)
		{
		}
	}
}
