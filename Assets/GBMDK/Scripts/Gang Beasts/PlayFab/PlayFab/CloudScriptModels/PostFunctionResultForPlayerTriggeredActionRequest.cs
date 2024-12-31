using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
	[Serializable]
	public class PostFunctionResultForPlayerTriggeredActionRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public ExecuteFunctionResult FunctionResult;

		public PlayerProfileModel PlayerProfile;

		public PlayStreamEventEnvelopeModel PlayStreamEventEnvelope;
	}
}
