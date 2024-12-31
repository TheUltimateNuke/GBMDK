using UnityEngine;
using UnityEngine.EventSystems;

namespace GB.Core.UI.Misc
{
	internal class ButtonAutoScroll : MonoBehaviour, ISelectHandler, IEventSystemHandler
	{
		public RectTransform viewport;

		public RectTransform contents;

		public RectTransform otherEffecter;

		public void OnSelect(BaseEventData eventData)
		{
		}
	}
}
