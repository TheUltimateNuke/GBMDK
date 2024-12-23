using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Coatsink.Common
{
	public static class StringX
	{
		public static string StringSplitIntoLines(string text, int maxCharsInLine)
		{
			return null;
		}

		public static string RemoveUpToChar(this string str, char chr, bool includeChar = false)
		{
			return null;
		}

		public static bool IsNullOrWhiteSpace(string str)
		{
			return false;
		}

		public static void AddFormat(this IList<string> stringList, string format, params object[] args)
		{
		}

		public static string PrettyName(this Type type)
		{
			return null;
		}

		public static void AppendPrettyName(this StringBuilder builder, Type type)
		{
		}

		public static int WriteCropped(this TextWriter writer, int size, string str)
		{
			return 0;
		}

		public static void WriteFixed(this TextWriter writer, int size, string str)
		{
		}

		public static void WriteFixed(this TextWriter writer, int size, string format, object arg0, object arg1 = null, object arg2 = null, object arg3 = null)
		{
		}
	}
}
