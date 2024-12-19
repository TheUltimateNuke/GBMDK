using System;
using System.Collections.Specialized;
using System.IO;
using UnityWebSocketSharp.Net;

namespace UnityWebSocketSharp
{
	internal class HttpRequest : HttpBase
	{
		private string _method;

		private string _target;

		internal string RequestLine => null;

		public override string MessageHeader => null;

		private HttpRequest(string method, string target, Version version, NameValueCollection headers)
			: base(null, null)
		{
		}

		internal HttpRequest(string method, string target)
			: base(null, null)
		{
		}

		internal static HttpRequest CreateConnectRequest(Uri targetUri)
		{
			return null;
		}

		internal static HttpRequest CreateWebSocketHandshakeRequest(Uri targetUri)
		{
			return null;
		}

		internal HttpResponse GetResponse(Stream stream, int millisecondsTimeout)
		{
			return null;
		}

		public void SetCookies(CookieCollection cookies)
		{
		}
	}
}
