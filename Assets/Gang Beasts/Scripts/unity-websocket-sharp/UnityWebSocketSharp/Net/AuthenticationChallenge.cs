using System.Collections.Specialized;

namespace UnityWebSocketSharp.Net
{
	internal class AuthenticationChallenge
	{
		private NameValueCollection _parameters;

		private AuthenticationSchemes _scheme;

		internal NameValueCollection Parameters => null;

		public AuthenticationSchemes Scheme => default(AuthenticationSchemes);

		private AuthenticationChallenge(AuthenticationSchemes scheme, NameValueCollection parameters)
		{
		}

		internal static string CreateNonceValue()
		{
			return null;
		}

		internal static AuthenticationChallenge Parse(string value)
		{
			return null;
		}

		internal static NameValueCollection ParseParameters(string value)
		{
			return null;
		}

		internal string ToBasicString()
		{
			return null;
		}

		internal string ToDigestString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
