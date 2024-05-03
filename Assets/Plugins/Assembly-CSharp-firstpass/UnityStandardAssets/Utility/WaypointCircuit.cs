using System;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		public class WaypointList
		{
			public WaypointCircuit circuit;

			public Transform[] items;
		}

		public struct RoutePoint
		{
			public Vector3 position;

			public Vector3 direction;

			public RoutePoint(Vector3 position, Vector3 direction):this()
			{
			}
		}

		public WaypointList waypointList;

		[SerializeField]
		private bool smoothRoute;

		private int numPoints;

		private Vector3[] points;

		private float[] distances;

		public float editorVisualisationSubsteps;

		private int p0n;

		private int p1n;

		private int p2n;

		private int p3n;

		private float i;

		private Vector3 P0;

		private Vector3 P1;

		private Vector3 P2;

		private Vector3 P3;

		public float Length { get; private set; }

		public Transform[] Waypoints => null;

		private void Awake()
		{
		}

		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		private void CachePositionsAndDistances()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void DrawGizmos(bool selected)
		{
		}
	}
}
