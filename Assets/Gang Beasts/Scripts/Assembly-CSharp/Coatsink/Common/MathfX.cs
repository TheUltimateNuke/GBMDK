using System;
using UnityEngine;

namespace Coatsink.Common
{
	public static class MathfX
	{
		public enum SineRemapEaseType
		{
			In = 0,
			Out = 1,
			InOut = 2
		}

		public const float tau = (float)Math.PI * 2f;

		public const float radsPerDeg = (float)Math.PI / 180f;

		public static float Percent(float min, float max, float value)
		{
			return 0f;
		}

		public static bool CloseTo(this float source, float other, float maxDist)
		{
			return false;
		}

		public static Vector3 ClosestPointLineSegment(Vector3 point, Vector3 start, Vector3 end)
		{
			return default(Vector3);
		}

		public static bool IntersectSegmentRectangle(Vector2 seg0, Vector2 seg1, Vector2 rectMin, Vector2 rectMax)
		{
			return false;
		}

		public static float LinearRemapLerp(float value, float valueStart = 0f, float valueEnd = 1f, float resultStart = 0f, float resultEnd = 1f)
		{
			return 0f;
		}

		public static float SineRemapLerp(float value, SineRemapEaseType easeType = SineRemapEaseType.InOut, float valueStart = 0f, float valueEnd = 1f, float resultStart = 0f, float resultEnd = 1f)
		{
			return 0f;
		}

		public static int Wrap(this int left, int right)
		{
			return 0;
		}

		public static float Wrap(this float left, float right)
		{
			return 0f;
		}

		public static Quaternion LockedAxisBillboard(Vector3 position, Vector3 forward, Vector3 eye)
		{
			return default(Quaternion);
		}

		public static float ForceAtEndsOfSpring(float springConst, float currentSpringDisplacement, float dampingCoefficient, float velocity)
		{
			return 0f;
		}

		public static Bounds GetWorldBounds(this GameObject go)
		{
			return default(Bounds);
		}

		public static float Step(float edge, float x)
		{
			return 0f;
		}
	}
}
