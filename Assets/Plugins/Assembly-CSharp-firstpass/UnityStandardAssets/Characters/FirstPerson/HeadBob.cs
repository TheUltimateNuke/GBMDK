using UnityEngine;
using UnityStandardAssets.Utility;

namespace UnityStandardAssets.Characters.FirstPerson
{
	public class HeadBob : MonoBehaviour
	{
		public Camera Camera;

		public CurveControlledBob motionBob;

		public LerpControlledBob jumpAndLandingBob;

		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		public float StrideInterval;

		[Range(0f, 1f)]
		public float RunningStrideLengthen;

		private bool m_PreviouslyGrounded;

		private Vector3 m_OriginalCameraPosition;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
