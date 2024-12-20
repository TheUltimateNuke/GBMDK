using System.Collections.Generic;
using GB.Networking.Objects;

namespace GB.Utils
{
	public static class GBUtils
	{
		private const char RAWTEXT_CODE_START = '\u0002';

		private const char RAWTEXT_CODE_END = '\u0003';

		public const int PARACARRIER_MAX = 10;

		public static string[] PARACARRIER_DATA;

		private static int _paraCarrier_Point;

		public static readonly List<string> NoUserSafeScenes;

		public static readonly List<string> NoneGamePlayScenes;

		public static bool IsHeadlessMode()
		{
			return false;
		}

		public static string StringConvert(string convert)
		{
			return null;
		}

		private static string ReadPart(string target, ref int point, bool para)
		{
			return null;
		}

		private static string ReadRawPart(string target, ref int point)
		{
			return null;
		}

		private static string ReadLocPart(string target, ref int point)
		{
			return null;
		}

		public static string RawTextWrap(string text)
		{
			return null;
		}

		public static string GetName(NetBeast beast, NetPlatform platform)
		{
			return null;
		}

		public static string ColourFromBeast(NetBeast beast)
		{
			return null;
		}
	}
}
