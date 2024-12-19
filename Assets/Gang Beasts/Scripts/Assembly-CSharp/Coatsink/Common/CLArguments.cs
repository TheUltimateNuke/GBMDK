using System;
using System.Collections.Generic;

namespace Coatsink.Common
{
	public static class CLArguments
	{
		public static Dictionary<string, List<string>> _commandLineArgs;

		public static Dictionary<string, List<string>> commandLineArgs => null;

		public static string GetArgument(string keyname, string defaultValue)
		{
			return null;
		}

		public static string[] GetArgumentsOrNull(string keyname)
		{
			return null;
		}

		public static bool GetArgumentExists(string keyname)
		{
			return false;
		}

		public static int GetIntArgument(string keyname, int defaultValue)
		{
			return 0;
		}

		public static T FirstOrDefault<T>(this IEnumerable<T> source, Func<T, bool> predicate, T defaultVal)
		{
			return default(T);
		}

		public static string Truncate(this string str, int maxLen)
		{
			return null;
		}
	}
}
