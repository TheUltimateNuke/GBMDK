using System.Collections.Generic;
using UnityEngine;

namespace Coatsink.Common
{
	public static class RectX
	{
		public static bool Overlaps(this Rect rect, IList<Rect> others)
		{
			return false;
		}

		public static Rect TranslatedBy(this Rect rect, Vector2 centerDelta)
		{
			return default(Rect);
		}

		public static Rect RecenteredTo(this Rect rect, Vector2 newCenter)
		{
			return default(Rect);
		}

		public static Rect RecenteredBy(this Rect rect, Vector2 offset)
		{
			return default(Rect);
		}

		public static Rect LerpPosition(Rect start, Rect end, float t)
		{
			return default(Rect);
		}

		public static Rect LerpPosition(Rect start, Vector2 endCenter, float t)
		{
			return default(Rect);
		}

		public static Rect RectOfCenterAndSize(Vector2 position, Vector2 size)
		{
			return default(Rect);
		}

		public static Rect RectOfSize(Vector2 size)
		{
			return default(Rect);
		}

		public static Vector2 XMinYMax(this Rect rect)
		{
			return default(Vector2);
		}

		public static Vector2 XMaxYMin(this Rect rect)
		{
			return default(Vector2);
		}

		public static Vector2 XMinYCtr(this Rect rect)
		{
			return default(Vector2);
		}

		public static Vector2 XMaxYCtr(this Rect rect)
		{
			return default(Vector2);
		}

		public static Vector2 XCtrYMin(this Rect rect)
		{
			return default(Vector2);
		}

		public static Vector2 XCtrYMax(this Rect rect)
		{
			return default(Vector2);
		}

		public static Vector2[] BorderPoints(this Rect rect)
		{
			return null;
		}

		public static Vector2[] CornerPoints(this Rect rect)
		{
			return null;
		}

		public static Vector2[] CornerPoints(this Rect rect, Vector2[] outArr)
		{
			return null;
		}

		public static Rect ExpandedFromCenterBy(this Rect rect, Vector2 expansion)
		{
			return default(Rect);
		}

		public static bool Contain(this IList<Rect> rects, Vector2 vect)
		{
			return false;
		}
	}
}
