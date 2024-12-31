using GB.Networking.Router;
using UnityEngine;
using UnityEngine.Events;

namespace GB.Networking.Utils
{
	public class RoutedEventListener : MonoBehaviour
	{
		[SerializeField]
		private EventRouter _eventRouter;

		[SerializeField]
		private int _triggerKey;

		[SerializeField]
		private UnityEvent OnTrigger;

		private void Awake()
		{
		}

		private void Trigger()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
