using System;
using System.Diagnostics;

namespace UnityWebSocketSharp
{
	internal class LogData
	{
		private StackFrame _caller;

		private DateTime _date;

		private LogLevel _level;

		private string _message;

		internal LogData(LogLevel level, StackFrame caller, string message)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
