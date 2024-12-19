using System;
using System.Collections.Specialized;
using WebSocketSharp.Net;

namespace WebSocketSharp
{
	internal class HttpResponse : HttpBase
	{
		private string _code;

		private string _reason;

		public CookieCollection Cookies => null;

		public bool HasConnectionClose => false;

		public bool IsProxyAuthenticationRequired => false;

		public bool IsRedirect => false;

		public bool IsUnauthorized => false;

		public bool IsWebSocketResponse => false;

		public string StatusCode => null;

		private HttpResponse(string code, string reason, Version version, NameValueCollection headers)
			: base(null, null)
		{
		}

		internal static HttpResponse Parse(string[] headerParts)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
