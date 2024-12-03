using System;

namespace UnityWebSocketSharp
{
	internal class WebSocketException : Exception
	{
		private ushort _code;

		public ushort Code => 0;

		private WebSocketException(ushort code, string message, Exception innerException)
		{
		}

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
