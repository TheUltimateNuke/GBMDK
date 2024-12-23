using System.Collections.Specialized;

namespace WebSocketSharp.Net
{
	internal class AuthenticationResponse : AuthenticationBase
	{
		private uint _nonceCount;

		internal uint NonceCount => 0u;

		internal AuthenticationResponse(NetworkCredential credentials)
			: base(default(AuthenticationSchemes), null)
		{
		}

		internal AuthenticationResponse(AuthenticationChallenge challenge, NetworkCredential credentials, uint nonceCount)
			: base(default(AuthenticationSchemes), null)
		{
		}

		internal AuthenticationResponse(AuthenticationSchemes scheme, NameValueCollection parameters, NetworkCredential credentials, uint nonceCount)
			: base(default(AuthenticationSchemes), null)
		{
		}

		private static string createA1(string username, string password, string realm)
		{
			return null;
		}

		private static string createA1(string username, string password, string realm, string nonce, string cnonce)
		{
			return null;
		}

		private static string createA2(string method, string uri)
		{
			return null;
		}

		private static string createA2(string method, string uri, string entity)
		{
			return null;
		}

		private static string hash(string value)
		{
			return null;
		}

		private void initAsDigest()
		{
		}

		internal static string CreateRequestDigest(NameValueCollection parameters)
		{
			return null;
		}

		internal override string ToBasicString()
		{
			return null;
		}

		internal override string ToDigestString()
		{
			return null;
		}
	}
}
