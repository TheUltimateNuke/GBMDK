using UnityEngine;

namespace CoreNet.Utils.Animation
{
	public class TransformClone : MonoBehaviour
	{
		[Header("Transform to clone")]
		public Transform targetTransform;

		[Header("Attributes")]
		public bool clonePosition;

		public bool cloneRotation;

		public bool cloneScale;

		[Header("Options")]
		public bool includeInitialPositionOffset;

		private Vector3 initialPositionOffset;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
