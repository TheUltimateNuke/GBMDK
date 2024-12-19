using UnityEngine;

namespace GB
{
	public class LinearTransformLimiter : MonoBehaviour
	{
		public Vector3 UpperLimit;

		public Vector3 LowerLimit;

		public bool UpdateOnFixed;

		private Vector3 adjustedUpper;

		private Vector3 adjustedLower;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
