using System.Collections.Generic;
using Femur;
using UnityEngine;

namespace GB
{
	public static class MasterBreakCache
	{
		private static List<ActorComponentCache> ActorCacheList;

		public static void CacheActor(Actor actor)
		{
		}

		public static void UncacheActor(Actor actor)
		{
		}

		public static Actor LookupBeast(this Rigidbody rb)
		{
			return null;
		}

		public static Actor LookupBeast(this Collider coll)
		{
			return null;
		}
	}
}
