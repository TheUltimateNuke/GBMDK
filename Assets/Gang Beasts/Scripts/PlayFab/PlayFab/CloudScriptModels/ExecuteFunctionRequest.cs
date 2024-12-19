using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
	[Serializable]
	public class ExecuteFunctionRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public EntityKey Entity;

		public string FunctionName;

		public object FunctionParameter;

		public bool? GeneratePlayStreamEvent;
	}
}
