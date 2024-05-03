using UnityEngine;
using UnityEngine.UI;

namespace GB.UI.Utils
{
	public class UIFader : MonoBehaviour
	{
		private AnimFloat alphaAnim;

		[SerializeField]
		private bool fadeOnEnable;

		[SerializeField]
		private float fadeTime;

		[SerializeField]
		private bool disableButtonsImmediately;

		private CanvasGroup cg;

		public void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		private void Update()
		{
		}

		public void FadeIn(Selectable toSelect = null)
		{
		}

		public void FadeInAndEnableInput(Selectable toSelect = null)
		{
		}

		public void FadeIn()
		{
		}

		public void FadeOut()
		{
		}

		private void OnFadeIn()
		{
		}

		private void OnFadeOut()
		{
		}
	}
}
