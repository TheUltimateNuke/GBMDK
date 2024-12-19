using System;
using System.Collections.Specialized;
using System.IO;
using UnityWebSocketSharp.Net;

namespace UnityWebSocketSharp
{
	internal class HttpResponse : HttpBase
	{
		private int _code;

		private string _reason;

		internal string StatusLine => null;

		public bool CloseConnection => false;

		public CookieCollection Cookies => null;

		public bool IsProxyAuthenticationRequired => false;

		public bool IsRedirect => false;

		public bool IsSuccess => false;

		public bool IsUnauthorized => false;

		public bool IsWebSocketResponse => false;

		public override string MessageHeader => null;

		private HttpResponse(int code, string reason, Version version, NameValueCollection headers)
			: base(null, null)
		{
		}

		internal static HttpResponse Parse(string[] messageHeader)
		{
			return null;
		}

		internal static HttpResponse ReadResponse(Stream stream, int millisecondsTimeout)
		{
			return null;
		}
	}
}
