using System;
using UnityEngine;

namespace Coatsink.Common
{
	public static class ComponentX
	{
		public static int GetFirstComponentTypePresent(this GameObject thisGo, out Component component, params Type[] types)
		{
			component = null;
			return 0;
		}

		public static int GetFirstComponentTypePresent(this Component thisComp, out Component component, params Type[] types)
		{
			component = null;
			return 0;
		}

		public static int GetFirstBehaviourTypePresent(this GameObject thisGo, out Behaviour behaviour, bool includeDisabled = true, params Type[] types)
		{
			behaviour = null;
			return 0;
		}

		public static int GetFirstBehaviourTypePresent(this Component thisComp, out Behaviour behaviour, bool includeDisabled = true, params Type[] types)
		{
			behaviour = null;
			return 0;
		}

		public static T GetComponentInAscendant<T>(this GameObject go, bool includeSelf = true, int depth = -1) where T : class
		{
			return null;
		}

		public static T GetComponentInAscendant<T>(this Component comp, bool includeSelf = true, int depth = -1) where T : class
		{
			return null;
		}
	}
}
