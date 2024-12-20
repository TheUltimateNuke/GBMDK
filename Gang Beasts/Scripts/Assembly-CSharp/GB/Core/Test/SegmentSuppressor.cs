using UnityEngine;

namespace GB.Core.Test
{
	[RequireComponent(typeof(Rigidbody))]
	public class SegmentSuppressor : MonoBehaviour
	{
		[SerializeField]
		private float VelocityMagnitudeThreshold;

		private Rigidbody _cachedRigidbody;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UpdateImpl()
		{
		}
	}
}
