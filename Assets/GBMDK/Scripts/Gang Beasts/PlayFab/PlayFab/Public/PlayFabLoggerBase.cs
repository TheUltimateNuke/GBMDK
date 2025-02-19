using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using UnityEngine;

namespace PlayFab.Public
{
	public abstract class PlayFabLoggerBase : IPlayFabLogger
	{
		[CompilerGenerated]
		private sealed class _003CRegisterLogger_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayFabLoggerBase _003C_003E4__this;

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
			public _003CRegisterLogger_003Ed__23(int _003C_003E1__state)
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

		private static readonly StringBuilder Sb;

		private readonly Queue<string> LogMessageQueue;

		private const int LOG_CACHE_INTERVAL_MS = 10000;

		private Thread _writeLogThread;

		private readonly object _threadLock;

		private static readonly TimeSpan _threadKillTimeout;

		private DateTime _threadKillTime;

		private bool _isApplicationPlaying;

		private int _pendingLogsCount;

		public IPAddress ip { get; set; }

		public int port { get; set; }

		public string url { get; set; }

		public virtual void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CRegisterLogger_003Ed__23))]
		private IEnumerator RegisterLogger()
		{
			return null;
		}

		public virtual void OnDisable()
		{
		}

		public virtual void OnDestroy()
		{
		}

		protected abstract void BeginUploadLog();

		protected abstract void UploadLog(string message);

		protected abstract void EndUploadLog();

		private void HandleUnityLog(string message, string stacktrace, LogType type)
		{
		}

		private void ActivateThreadWorker()
		{
		}

		private void WriteLogThreadWorker()
		{
		}
	}
}
