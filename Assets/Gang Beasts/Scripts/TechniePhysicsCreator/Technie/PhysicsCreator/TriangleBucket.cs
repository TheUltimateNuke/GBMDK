using System.Collections.Generic;
using UnityEngine;

namespace Technie.PhysicsCreator
{
	public class TriangleBucket
	{
		private List<Triangle> triangles;

		private Vector3 averagedNormal;

		private Vector3 averagedCenter;

		private float totalArea;

		public float Area => 0f;

		public TriangleBucket(Triangle initialTriangle)
		{
		}

		public void Add(Triangle t)
		{
		}

		public void Add(TriangleBucket otherBucket)
		{
		}

		private void CalculateNormal()
		{
		}

		public Vector3 GetAverageNormal()
		{
			return default(Vector3);
		}

		public Vector3 GetAverageCenter()
		{
			return default(Vector3);
		}

		private void CalcTotalArea()
		{
		}
	}
}
