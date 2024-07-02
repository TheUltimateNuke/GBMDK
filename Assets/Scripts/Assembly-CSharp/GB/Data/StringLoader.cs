using System.Collections.Generic;
using System.Text;
using UnityEngine.Localization;

namespace GB.Data
{
	public static class StringLoader
	{
		private const int _maxArgs = 10;

		private static List<object> _args;

		private static StringBuilder ms_PlatformStringBuilder;

		private const string SwitchConventionalPostfix = "_SWITCH";

		public static string LoadString(string key)
		{
			return null;
		}

		public static string LoadRawString(string key, string[] arguments = null, int startIndex = 0, int count = 0)
		{
			return null;
		}

		private static bool TryLoadStringByPlatform(ref string pulledString, string key, IList<object> args = null, Locale locale = null)
		{
			return false;
		}
	}
}
