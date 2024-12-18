using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
	[Serializable]
	public class UnregisterFunctionRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string FunctionName;
	}
}
