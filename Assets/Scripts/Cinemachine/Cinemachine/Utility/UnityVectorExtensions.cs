using UnityEngine;

namespace Cinemachine.Utility
{
	public static class UnityVectorExtensions
	{
		public const float Epsilon = 0.0001f;

		public static bool IsNaN(this Vector2 v)
		{
			return false;
		}

		public static bool IsNaN(this Vector3 v)
		{
			return false;
		}

		public static float ClosestPointOnSegment(this Vector3 p, Vector3 s0, Vector3 s1)
		{
			return 0f;
		}

		public static float ClosestPointOnSegment(this Vector2 p, Vector2 s0, Vector2 s1)
		{
			return 0f;
		}

		public static Vector3 ProjectOntoPlane(this Vector3 vector, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		public static Vector2 SquareNormalize(this Vector2 v)
		{
			return default(Vector2);
		}

		public static int FindIntersection(in Vector2 p1, in Vector2 p2, in Vector2 q1, in Vector2 q2, out Vector2 intersection)
		{
			intersection = default(Vector2);
			return 0;
		}

		private static float Cross(this Vector2 v1, Vector2 v2)
		{
			return 0f;
		}

		public static Vector2 Abs(this Vector2 v)
		{
			return default(Vector2);
		}

		public static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		public static bool IsUniform(this Vector2 v)
		{
			return false;
		}

		public static bool IsUniform(this Vector3 v)
		{
			return false;
		}

		public static bool AlmostZero(this Vector3 v)
		{
			return false;
		}

		public static float Angle(Vector3 v1, Vector3 v2)
		{
			return 0f;
		}

		public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 up)
		{
			return 0f;
		}

		public static Quaternion SafeFromToRotation(Vector3 v1, Vector3 v2, Vector3 up)
		{
			return default(Quaternion);
		}

		public static Vector3 SlerpWithReferenceUp(Vector3 vA, Vector3 vB, float t, Vector3 up)
		{
			return default(Vector3);
		}
	}
}
