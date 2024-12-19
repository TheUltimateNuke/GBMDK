using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EventsModels
{
	[Serializable]
	public class WriteEventsRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public List<EventContents> Events;
	}
}
