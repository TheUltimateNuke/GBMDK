using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
	[Serializable]
	public class RegisterQueuedFunctionRequest : PlayFabRequestCommon
	{
		public string ConnectionString;

		public Dictionary<string, string> CustomTags;

		public string FunctionName;

		public string QueueName;
	}
}
