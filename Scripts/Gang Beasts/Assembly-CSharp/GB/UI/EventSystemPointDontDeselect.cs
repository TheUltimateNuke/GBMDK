using UnityEngine;
using UnityEngine.EventSystems;

namespace GB.UI
{
	public class EventSystemPointDontDeselect : MonoBehaviour
	{
		private EventSystem _eventCache;

		public GameObject lastSelected;

		public EventSystem EventSys => null;

		private void Update()
		{
		}
	}
}
