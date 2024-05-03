using System;
using UnityEngine;

namespace GB.Utils
{
	public static class EnumUtils
	{
		public class EnumFlagsAttribute : PropertyAttribute
		{
		}

		public static bool HasFlag(this Enum self, Enum checkValue)
		{
			return false;
		}

		public static T ParseEnum<T>(string value)
		{
			return default(T);
		}
	}
}
