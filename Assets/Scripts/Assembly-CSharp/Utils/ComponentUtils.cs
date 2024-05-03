using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Utils
{
	public static class ComponentUtils
	{
		public static void RemoveAll<T>(this GameObject target) where T : MonoBehaviour
		{
		}

		public static void RemoveAllExcept(this GameObject target, List<Type> whitelist)
		{
		}

		public static void CopyComponentsFrom(this GameObject to, GameObject from)
		{
		}

		public static Component GetCopyOf(this Component comp, Component other)
		{
			return null;
		}

		public static Component AddComponent(this GameObject go, Component toAdd)
		{
			return null;
		}

		public static T GetCopyOf<T>(this Component comp, T other) where T : Component
		{
			return null;
		}

		public static T AddComponent<T>(this GameObject go, T toAdd) where T : Component
		{
			return null;
		}

		public static PropertyInfo[] GetPublicProperties(this Type type)
		{
			return null;
		}
	}
}
