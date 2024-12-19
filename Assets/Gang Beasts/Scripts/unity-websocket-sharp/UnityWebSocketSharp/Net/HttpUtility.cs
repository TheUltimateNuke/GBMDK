using System.Text;

namespace UnityWebSocketSharp.Net
{
	internal static class HttpUtility
	{
		private static char[] _hexChars;

		private static object _sync;

		static HttpUtility()
		{
		}

		private static int getNumber(char c)
		{
			return 0;
		}

		private static int getNumber(byte[] bytes, int offset, int count)
		{
			return 0;
		}

		private static byte[] urlDecodeToBytes(byte[] bytes, int offset, int count)
		{
			return null;
		}

		internal static Encoding GetEncoding(string contentType)
		{
			return null;
		}

		public static string UrlDecode(string s, Encoding encoding)
		{
			return null;
		}
	}
}
