using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PlayFab.AuthenticationModels;
using PlayFab.EventsModels;
using PlayFab.Internal;
using UnityEngine;

namespace PlayFab.Party
{
	internal sealed class PlayFabEventTracer : SingletonMonoBehaviour<PlayFabEventTracer>
	{
		[CompilerGenerated]
		private sealed class _003CWaitUntilEntityLoggedIn_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float secondsBetweenWait;

			public PlayFabEventTracer _003C_003E4__this;

			private WaitForSeconds _003Cdelay_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CWaitUntilEntityLoggedIn_003Ed__14(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		private Guid gameSessionID;

		private Queue<EventContents> eventsRequests;

		private Queue<EventContents> eventsPending;

		private PlayFab.EventsModels.EntityKey entityKey;

		private const string eventNamespace = "playfab.party";

		private const float delayBetweenEntityLoggedIn = 5f;

		private const int maxBatchSizeInEvents = 10;

		private long lastErrorTimeInMillisecond;

		private int retryCount;

		private PlayFabEventsInstanceAPI eventApi;

		private PlayFabEventTracer()
		{
		}

		private void SetCommonTelemetryProperties(Dictionary<string, object> payload)
		{
		}

		private static long GetCurrentTimeInMilliseconds()
		{
			return 0L;
		}

		public void OnPlayFabMultiPlayerManagerInitialize()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitUntilEntityLoggedIn_003Ed__14))]
		private IEnumerator WaitUntilEntityLoggedIn(float secondsBetweenWait)
		{
			return null;
		}

		private void GetEntityTokenCompleted(GetEntityTokenResponse response)
		{
		}

		private void GetEntityTokenFailed(PlayFabError error)
		{
		}

		public void OnPlayFabPartyError(uint errorCode, PlayFabMultiplayerManagerErrorType type)
		{
		}

		public void DoWork()
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
	}
}
