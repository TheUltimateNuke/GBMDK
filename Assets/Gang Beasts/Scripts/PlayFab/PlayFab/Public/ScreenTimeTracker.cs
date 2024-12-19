using System;
using System.Collections.Generic;
using PlayFab.EventsModels;

namespace PlayFab.Public
{
	public class ScreenTimeTracker : IScreenTimeTracker
	{
		private Guid focusId;

		private Guid gameSessionID;

		private bool initialFocus;

		private bool isSending;

		private DateTime focusOffDateTime;

		private DateTime focusOnDateTime;

		private Queue<EventContents> eventsRequests;

		private EntityKey entityKey;

		private const string eventNamespace = "com.playfab.events.sessions";

		private const int maxBatchSizeInEvents = 10;

		private PlayFabEventsInstanceAPI eventApi;

		private void EnsureSingleGameSessionId()
		{
		}

		public void ClientSessionStart(string entityId, string entityType, string playFabUserId)
		{
		}

		public void OnApplicationFocus(bool isFocused)
		{
		}

		public void Send()
		{
		}

		private void EventSentSuccessfulCallback(WriteEventsResponse response)
		{
		}

		private void EventSentErrorCallback(PlayFabError response)
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnDestroy()
		{
		}

		public void OnApplicationQuit()
		{
		}
	}
}
