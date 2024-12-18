using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class CancelServerBackfillTicketRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public string QueueName;

		public string TicketId;
	}
}
