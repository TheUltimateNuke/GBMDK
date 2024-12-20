using UnityEngine;
using UnityEngine.Events;

namespace GB.Environment
{
	public class CustomBreakEvent : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent OnBreakOccured;

		[SerializeField]
		private bool RunClientside;

		private void OnJointBreak(float force)
		{
		}
	}
}
