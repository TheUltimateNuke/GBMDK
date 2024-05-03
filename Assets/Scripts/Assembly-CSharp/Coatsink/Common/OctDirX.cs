using UnityEngine;

namespace Coatsink.Common
{
	public static class OctDirX
	{
		public static float AngleCW(this OctDir to, OctDir from = OctDir.Up, float circumference = 360f)
		{
			return 0f;
		}

		public static OctDir ToSimpleDir(this float angle, float up = 0f, float circumference = 360f)
		{
			return default(OctDir);
		}

		public static Vector3 ToV3XZ(this OctDir dir)
		{
			return default(Vector3);
		}

		public static v2i ToV2i(this OctDir dir)
		{
			return default(v2i);
		}

		public static OctDir ToSimpleDirXZ(this Vector3 vect)
		{
			return default(OctDir);
		}

		public static OctDir Negative(this OctDir dir)
		{
			return default(OctDir);
		}
	}
}
