using UnityEngine;

namespace UnityStandardAssets.Utility
{
	public class WaypointProgressTracker : MonoBehaviour
	{
		public enum ProgressStyle
		{
			SmoothAlongRoute = 0,
			PointToPoint = 1
		}

		[SerializeField]
		private WaypointCircuit circuit;

		[SerializeField]
		private float lookAheadForTargetOffset;

		[SerializeField]
		private float lookAheadForTargetFactor;

		[SerializeField]
		private float lookAheadForSpeedOffset;

		[SerializeField]
		private float lookAheadForSpeedFactor;

		[SerializeField]
		private ProgressStyle progressStyle;

		[SerializeField]
		private float pointToPointThreshold;

		public Transform target;

		private float progressDistance;

		private int progressNum;

		private Vector3 lastPosition;

		private float speed;

		public WaypointCircuit.RoutePoint targetPoint { get; private set; }

		public WaypointCircuit.RoutePoint speedPoint { get; private set; }

		public WaypointCircuit.RoutePoint progressPoint { get; private set; }

		private void Start()
		{
		}

		public void Reset()
		{
		}

		private void Update()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
