using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;

namespace GB.UI
{
	public class CountdownHandler : MonoBehaviour
	{
		[SerializeField]
		private StartGameCountdown _countdownManager;

		[SerializeField]
		private GameObject _countdownObject;

		[SerializeField]
		private LocalizeStringEvent _countdownText;

		public bool playCountdownAudio;

		private int lastVal;

		private TextMeshProUGUI _countdownTextMesh;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void TimerChanged(float obj)
		{
		}

		private void TimerActive(bool obj)
		{
		}
	}
}
