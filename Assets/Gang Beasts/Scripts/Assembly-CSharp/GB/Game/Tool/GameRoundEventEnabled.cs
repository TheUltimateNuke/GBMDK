using UnityEngine;

namespace GB.Game.Tool
{
	public class GameRoundEventEnabled : MonoBehaviour
	{
		private enum Event
		{
			Setup = 0,
			Start = 1,
			End = 2,
			PostEnd = 3
		}

		[SerializeField]
		private Event _OnEvent;

		[SerializeField]
		private GameObject[] _enabled;

		[SerializeField]
		private GameObject[] _disabled;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEvent()
		{
		}
	}
}
