using System;
using System.Collections.Generic;
using System.Text;

namespace PlayFab
{
	public class PlayFabError
	{
		public string ApiEndpoint;

		public int HttpCode;

		public string HttpStatus;

		public PlayFabErrorCode Error;

		public string ErrorMessage;

		public Dictionary<string, List<string>> ErrorDetails;

		public object CustomData;

		public uint? RetryAfterSeconds;

		[ThreadStatic]
		private static StringBuilder _tempSb;

		public override string ToString()
		{
			return null;
		}

		public string GenerateErrorReport()
		{
			return null;
		}
	}
}
