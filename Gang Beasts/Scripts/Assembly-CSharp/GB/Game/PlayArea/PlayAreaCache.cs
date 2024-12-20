using System.Collections.Generic;
using UnityEngine;

namespace GB.Game.PlayArea
{
	public static class PlayAreaCache
	{
		private class FallbackArea : IPlayArea
		{
			private Vector3 _range;

			public bool InArea(Vector3 point)
			{
				return false;
			}
		}

		private static FallbackArea _fallback;

		private static List<IPlayArea> _areaCache;

		public static List<IPlayArea> Areas => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static void RegisterArea(IPlayArea area)
		{
		}

		public static void DeregisterArea(IPlayArea area)
		{
		}

		public static IPlayArea InPlayArea(Vector3 point)
		{
			return null;
		}
	}
}
