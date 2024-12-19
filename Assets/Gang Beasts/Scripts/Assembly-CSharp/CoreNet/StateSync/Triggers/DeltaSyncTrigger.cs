using UnityEngine;

namespace CoreNet.StateSync.Triggers
{
	public class DeltaSyncTrigger : BaseSyncTrigger
	{
		public float PositionThreshold;

		public float RotationThreshold;

		private Vector3 _InitPosition;

		private Quaternion _InitRotation;

		public void Start()
		{
		}

		public void Update()
		{
		}

		private void CheckDeltas()
		{
		}
	}
}
