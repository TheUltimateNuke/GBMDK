using UnityEngine;

namespace Coatsink.Common
{
	public struct Matrix2x2
	{
		public float m00;

		public float m01;

		public float m10;

		public float m11;

		public static readonly Matrix2x2 Identity;

		public Matrix2x2(float m00, float m01, float m10, float m11)
		{
			this.m00 = 0f;
			this.m01 = 0f;
			this.m10 = 0f;
			this.m11 = 0f;
		}

		public static Matrix2x2 Rotation(float angle)
		{
			return default(Matrix2x2);
		}

		public static Matrix2x2 RotationFromVec2(Vector2 vec)
		{
			return default(Matrix2x2);
		}

		public static float Mat22GetAngle(Matrix2x2 mat)
		{
			return 0f;
		}

		public static Matrix2x2 Mat22Inverse(Matrix2x2 mat)
		{
			return default(Matrix2x2);
		}

		public static Vector2 operator *(Matrix2x2 mat, Vector2 vec)
		{
			return default(Vector2);
		}
	}
}
