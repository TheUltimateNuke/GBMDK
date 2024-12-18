using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Audio
{
	public class UIButtonSFX : MonoBehaviour, ISelectHandler, IEventSystemHandler
	{
		public bool PlayOnHighlight;

		public bool PlayOnClick;

		public AudioMixerController.MixerGroup mixerGroup;

		private Button button;

		public AudioClip OverrideHightlightSFX;

		public AudioClip OverrideClickSFX;

		private float timer;

		private const float kEnableTimeout = 0.5f;

		private bool audioEnabled;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		public void OnSelect(BaseEventData data)
		{
		}

		private void OnButtonClick()
		{
		}
	}
}
