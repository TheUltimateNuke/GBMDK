using System.Collections.Specialized;

namespace WebSocketSharp.Net
{
	internal class AuthenticationChallenge : AuthenticationBase
	{
		private AuthenticationChallenge(AuthenticationSchemes scheme, NameValueCollection parameters)
			: base(default(AuthenticationSchemes), null)
		{
		}

		internal static AuthenticationChallenge Parse(string value)
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
