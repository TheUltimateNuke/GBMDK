using UnityEngine;

namespace Coatsink.Common
{
	public static class SceneX
	{
		public static bool IsAncestorOf(this Component a, Component c)
		{
			return false;
		}

		public static Component GetClosestInAncestry<TA, TB>(this Component c, out TA aa, out TB ab, bool includeSelf) where TA : Component where TB : Component
		{
			aa = null;
			ab = null;
			return null;
		}

		public static void SetLocalPosY(this Transform xform, float y)
		{
		}
	}
}
