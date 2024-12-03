using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class GetServerBackfillTicketRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public bool EscapeObject;

		public string QueueName;

		public string TicketId;
	}
}