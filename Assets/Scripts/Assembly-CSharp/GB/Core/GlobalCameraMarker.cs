using System.Collections.Generic;
using UnityEngine;

namespace GB.Core
{
	public class GlobalCameraMarker : MonoBehaviour
	{
		[HideInInspector]
		[SerializeField]
		public List<CMOffsets.CMOffset> CameraOffsets;

		[SerializeField]
		public int priority;

		[SerializeField]
		public bool looping;

		[SerializeField]
		public float Distance_MinimumToTarget;

		[SerializeField]
		public float Distance_MaximumToTarget;

		[SerializeField]
		public float RoundEnd_ZoomIn;

		[SerializeField]
		public float RoundEnd_ZoomDuration;

		[SerializeField]
		public float RoundEnd_DistanceMultiplier;

		[SerializeField]
		public Transform TrackingDummy;

		[HideInInspector]
		public int GizmoCameraOffsetID;

		public static bool ShowAllNodes;

		public float OrbitLerpSpeed;

		[SerializeField]
		public bool OrbitStyle;

		private Color[] nodeColors;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void DrawNodeGizmo(Vector3 selfTarget, int orientID, float distance)
		{
		}

		public void SetupCameraFromMarker(GlobalCamera camera)
		{
		}
	}
}
