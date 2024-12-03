using UnityEngine;

namespace Cinemachine.Utility
{
	public static class SplineHelpers
	{
		public static Vector3 Bezier3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return default(Vector3);
		}

		public static Vector3 BezierTangent3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return default(Vector3);
		}

		public static float Bezier1(float t, float p0, float p1, float p2, float p3)
		{
			return 0f;
		}

		public static float BezierTangent1(float t, float p0, float p1, float p2, float p3)
		{
			return 0f;
		}

		public static void ComputeSmoothControlPoints(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2)
		{
		}

		public static void ComputeSmoothControlPointsLooped(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2)
		{
		}
	}
}
