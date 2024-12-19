using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
	[Serializable]
	public class PostFunctionResultForEntityTriggeredActionRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public EntityKey Entity;

		public ExecuteFunctionResult FunctionResult;
	}
}
