using UnityEngine;

namespace UnityStandardAssets.Utility
{
	public class SimpleMouseRotator : MonoBehaviour
	{
		public Vector2 rotationRange;

		public float rotationSpeed;

		public float dampingTime;

		public bool autoZeroVerticalOnMobile;

		public bool autoZeroHorizontalOnMobile;

		public bool relative;

		private Vector3 m_TargetAngles;

		private Vector3 m_FollowAngles;

		private Vector3 m_FollowVelocity;

		private Quaternion m_OriginalRotation;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
