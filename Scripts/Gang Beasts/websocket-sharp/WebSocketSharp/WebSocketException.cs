using System;

namespace WebSocketSharp
{
	public class WebSocketException : Exception
	{
		private CloseStatusCode _code;

		public CloseStatusCode Code => default(CloseStatusCode);

		internal WebSocketException(string message)
		{
		}

		internal WebSocketException(CloseStatusCode code)
		{
		}

		internal WebSocketException(string message, Exception innerException)
		{
		}

		internal WebSocketException(CloseStatusCode code, Exception innerException)
		{
		}

		internal WebSocketException(CloseStatusCode code, string message)
		{
		}

		internal WebSocketException(CloseStatusCode code, string message, Exception innerException)
		{
		}
	}
}
