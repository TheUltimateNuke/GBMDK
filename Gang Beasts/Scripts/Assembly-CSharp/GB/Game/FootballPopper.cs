using System;
using UnityEngine;
using UnityEngine.Events;

namespace GB.Game
{
	[RequireComponent(typeof(Collider))]
	public class FootballPopper : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent AdditionalTriggerEvents;

		private Action<Football> cachedResponse;

		private void OnTriggerEnter(Collider other)
		{
		}

		public void SetupPopperLogic(Action<Football> response)
		{
		}
	}
}
