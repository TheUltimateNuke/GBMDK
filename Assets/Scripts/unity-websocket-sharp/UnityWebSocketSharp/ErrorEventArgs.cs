using System;

namespace UnityWebSocketSharp
{
	internal class ErrorEventArgs : EventArgs
	{
		private Exception _exception;

		private string _message;

		public string Message => null;

		internal ErrorEventArgs(string message, Exception exception)
		{
		}
	}
}
