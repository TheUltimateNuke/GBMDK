using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Coatsink.Platform.Utils
{
	public class ThreadHandler
	{
		public static Action<ThreadHandler> SystemThreadSetup;

		private string _threadName;

		private object _threadLock;

		private Thread _thread;

		private object _threadPauseLock;

		private bool _threadPause;

		private object _threadPausedLock;

		private bool _threadPaused;

		private object _threadAbortLock;

		private bool _threadAbort;

		private object _threadOnceLock;

		private bool _threadOnce;

		private bool _threadComplete;

		[CompilerGenerated]
		private Action OnCompletionOff;

		[CompilerGenerated]
		private Action OnCompletionMain;

		private ThreadPriority _priority;

		private object _threadCallLock;

		private List<Action> _threadCalls;

		private object _threadRestartLock;

		private bool _threadRestart;

		private int _numberCalling;

		public bool Running => false;

		public bool PauseThread
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool AbortThread
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RunThreadOnce => false;

		public ThreadPriority Priority
		{
			set
			{
			}
		}

		public ThreadHandler(string name)
		{
		}

		~ThreadHandler()
		{
		}

		public void Start()
		{
		}

		public void Abort(bool block)
		{
		}

		private void Complete()
		{
		}

		public void AddPart(Action part)
		{
		}

		public void RemovePart(Action part)
		{
		}

		public void Restart()
		{
		}

		private void ThreadLoop()
		{
		}
	}
}
