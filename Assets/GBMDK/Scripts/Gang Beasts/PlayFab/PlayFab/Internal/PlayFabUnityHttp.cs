using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace PlayFab.Internal
{
	public class PlayFabUnityHttp : ITransportPlugin, IPlayFabPlugin
	{
		[CompilerGenerated]
		private sealed class _003CSimpleCallCoroutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public byte[] payload;

			public string fullUrl;

			public Action<string> errorCallback;

			public Action<byte[]> successCallback;

			public string method;

			private UnityWebRequest _003Cwww_003E5__2;

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

			object IEnumerator<object>.Current => throw new NotImplementedException();

			object IEnumerator.Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CSimpleCallCoroutine_003Ed__10(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			void IEnumerator.Reset()
			{
				throw new NotImplementedException();
			}

			void IDisposable.Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[CompilerGenerated]
		private sealed class _003CPost_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CallRequestContainer reqContainer;

			public PlayFabUnityHttp _003C_003E4__this;

			private UnityWebRequest _003Cwww_003E5__2;

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

			object IEnumerator<object>.Current => throw new NotImplementedException();

			object IEnumerator.Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CPost_003Ed__12(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			void IEnumerator.Reset()
			{
				throw new NotImplementedException();
			}

			void IDisposable.Dispose()
			{
				throw new NotImplementedException();
			}
		}

		private bool _isInitialized;

		private readonly int _pendingWwwMessages;

		public bool IsInitialized => false;

		public void Initialize()
		{
		}

		public void Update()
		{
		}

		public void OnDestroy()
		{
		}

		public void SimpleGetCall(string fullUrl, Action<byte[]> successCallback, Action<string> errorCallback)
		{
		}

		public void SimplePutCall(string fullUrl, byte[] payload, Action<byte[]> successCallback, Action<string> errorCallback)
		{
		}

		public void SimplePostCall(string fullUrl, byte[] payload, Action<byte[]> successCallback, Action<string> errorCallback)
		{
		}

		[IteratorStateMachine(typeof(_003CSimpleCallCoroutine_003Ed__10))]
		private static IEnumerator SimpleCallCoroutine(string method, string fullUrl, byte[] payload, Action<byte[]> successCallback, Action<string> errorCallback)
		{
			return null;
		}

		public void MakeApiCall(object reqContainerObj)
		{
		}

		[IteratorStateMachine(typeof(_003CPost_003Ed__12))]
		private IEnumerator Post(CallRequestContainer reqContainer)
		{
			return null;
		}

		public int GetPendingMessages()
		{
			return 0;
		}

		public void OnResponse(string response, CallRequestContainer reqContainer)
		{
		}

		public void OnError(string error, CallRequestContainer reqContainer)
		{
		}
	}
}
