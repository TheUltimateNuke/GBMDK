using UnityEngine;

namespace GB.UI
{
	public class MenuFocusDisabler : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup[] menuGroupRefs;

		private bool gamePrepped;

		private void Start()
		{
		}

		private void OnApplicationFocus(bool active)
		{
		}
	}
}
