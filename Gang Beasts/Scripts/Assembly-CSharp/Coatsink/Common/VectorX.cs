using System.Collections.Generic;
using UnityEngine;

namespace Coatsink.Common
{
	public static class VectorX
	{
		public static float Min(Vector3 v)
		{
			return 0f;
		}

		public static float Max(Vector3 v)
		{
			return 0f;
		}

		public static float Min(Vector2 v)
		{
			return 0f;
		}

		public static float Max(Vector2 v)
		{
			return 0f;
		}

		public static Vector2 Min(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		public static Vector2 Max(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		public static void OrthoNormal(Vector3 foward, out Vector3 up, out Vector3 right)
		{
			up = default(Vector3);
			right = default(Vector3);
		}

		public static Vector2? IntersectionWith(this Ray2D ray1, Ray2D ray2)
		{
			return null;
		}

		public static Vector3 V2ToV3(this Vector2 v2, float z)
		{
			return default(Vector3);
		}

		public static Vector2 xz(this Vector3 v)
		{
			return default(Vector2);
		}

		public static Vector3 xNy(this Vector2 v, float n = 0f)
		{
			return default(Vector3);
		}

		public static Vector4 V2ToV4(this Vector2 v2, float z, float w)
		{
			return default(Vector4);
		}

		public static Vector4 V3ToV4(this Vector3 v3, float w)
		{
			return default(Vector4);
		}

		public static Vector3 RepX(this Vector3 vect, float newVal)
		{
			return default(Vector3);
		}

		public static Vector3 RepY(this Vector3 vect, float newVal)
		{
			return default(Vector3);
		}

		public static Vector3 RepZ(this Vector3 vect, float newVal)
		{
			return default(Vector3);
		}

		public static Vector3 RepXY(this Vector3 vect, float newX, float newY)
		{
			return default(Vector3);
		}

		public static Vector3 RepXZ(this Vector3 vect, float newX, float newZ)
		{
			return default(Vector3);
		}

		public static Vector3 RepYZ(this Vector3 vect, float newY, float newZ)
		{
			return default(Vector3);
		}

		public static Vector3 ScaleX(this Vector3 vect, float scale)
		{
			return default(Vector3);
		}

		public static Vector3 ScaleY(this Vector3 vect, float scale)
		{
			return default(Vector3);
		}

		public static Vector3 ScaleZ(this Vector3 vect, float scale)
		{
			return default(Vector3);
		}

		public static Vector3 ScaleXY(this Vector3 vect, float scaleX, float scaleY)
		{
			return default(Vector3);
		}

		public static Vector3 ScaleXZ(this Vector3 vect, float scaleX, float scaleZ)
		{
			return default(Vector3);
		}

		public static Vector3 ScaleYZ(this Vector3 vect, float scaleY, float scaleZ)
		{
			return default(Vector3);
		}

		public static Vector3 ClampedToMagnitude(this Vector3 vect, float magClamp)
		{
			return default(Vector3);
		}

		public static Vector2 ClampedToMagnitude(this Vector2 vect, float magClamp)
		{
			return default(Vector2);
		}

		public static Vector2 Rounded(this Vector2 vect)
		{
			return default(Vector2);
		}

		public static Vector2 ClosestTo(this IList<Vector2> vects, Vector2 target)
		{
			return default(Vector2);
		}

		public static bool IsCloseTo(this Vector2 vect, Vector2 other, float maxDist)
		{
			return false;
		}

		public static Vector3 V3LerpNoClamp(Vector3 from, Vector3 to, float t)
		{
			return default(Vector3);
		}

		public static Vector3 Reciprocal(this Vector3 vect)
		{
			return default(Vector3);
		}
	}
}
