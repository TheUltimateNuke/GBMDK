using UnityEngine;

namespace Utils
{
	public static class MathUtils
	{
		public static class BezierCurveUtils
		{
			public enum CurveType
			{
				Linear = 0,
				Quadratic = 1,
				Cubic = 2
			}

			public static float Linear(float a, float b, float t)
			{
				return 0f;
			}

			public static float LinearDerivative(float a, float b, float t)
			{
				return 0f;
			}

			public static float Quadratic(float a, float b, float c, float t)
			{
				return 0f;
			}

			public static float QuadraticDerivative(float a, float b, float c, float t)
			{
				return 0f;
			}

			public static float Cubic(float a, float b, float c, float d, float t)
			{
				return 0f;
			}

			public static float CubicDerivative(float a, float b, float c, float d, float t)
			{
				return 0f;
			}

			public static Vector2 Linear(Vector2 a, Vector2 b, float t)
			{
				return default(Vector2);
			}

			public static Vector2 Quadratic(Vector2 a, Vector2 b, Vector2 c, float t)
			{
				return default(Vector2);
			}

			public static Vector2 Cubic(Vector2 a, Vector2 b, Vector2 c, Vector2 d, float t)
			{
				return default(Vector2);
			}

			public static Vector2 LinearDerivative(Vector2 a, Vector2 b, float t)
			{
				return default(Vector2);
			}

			public static Vector2 QuadraticDerivative(Vector2 a, Vector2 b, Vector2 c, float t)
			{
				return default(Vector2);
			}

			public static Vector2 CubicDerivative(Vector2 a, Vector2 b, Vector2 c, Vector2 d, float t)
			{
				return default(Vector2);
			}
		}

		public static Quaternion AverageQuaternion(ref Vector4 cumulative, Quaternion newRotation, float weight, Quaternion firstRotation, int addAmount)
		{
			return default(Quaternion);
		}

		public static Quaternion NormalizeQuaternion(float x, float y, float z, float w)
		{
			return default(Quaternion);
		}

		public static Quaternion InverseSignQuaternion(Quaternion q)
		{
			return default(Quaternion);
		}

		public static bool AreQuaternionsClose(Quaternion q1, Quaternion q2)
		{
			return false;
		}
	}
}
