using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class GetMatchmakingQueueRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string QueueName;
	}
}