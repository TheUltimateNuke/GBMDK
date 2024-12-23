using UnityEngine;

namespace GB.Game.Objective
{
	public class ObjectiveTriggerPass : MonoBehaviour
	{
		[SerializeField]
		private ObjectivePartTrigger _passOn;

		[SerializeField]
		private ObjectivePartInArea _exitOn;

		private void OnEnable()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}
	}
}
