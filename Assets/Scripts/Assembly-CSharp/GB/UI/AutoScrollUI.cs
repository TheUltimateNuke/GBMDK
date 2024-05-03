using UnityEngine;
using UnityEngine.UI;

namespace GB.UI
{
	public class AutoScrollUI : MonoBehaviour
	{
		private RectTransform selfXForm;

		private RectTransform parentXForm;

		private Graphic contentRef;

		[SerializeField]
		private float scrollSpeed;

		[SerializeField]
		private float edgeDelay;

		private bool timerActive;

		private float timer;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
