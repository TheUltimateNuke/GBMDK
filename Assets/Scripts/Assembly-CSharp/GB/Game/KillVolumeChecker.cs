using UnityEngine;

namespace GB.Game
{
	public class KillVolumeChecker : MonoBehaviour
	{
		private int killVolumeLayer;

		private IKillTriggered[] killTriggered;

		private KillVolumeEvent _triggerEvent;

		[SerializeField]
		private GameObject _scanObject;

		private bool HasTriggers => false;

		private void Start()
		{
		}

		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		private void TriggerEvents()
		{
		}

		private void KillVolumeCheck(Collider otherCollider)
		{
		}
	}
}
