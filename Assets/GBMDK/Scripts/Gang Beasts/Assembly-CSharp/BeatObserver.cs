using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SynchronizerData;
using UnityEngine;

public class BeatObserver : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitOnBeat_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BeatObserver _003C_003E4__this;

		public BeatType beatType;

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
		public _003CWaitOnBeat_003Ed__5(int _003C_003E1__state)
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

	[Range(0f, 500f)]
	public float beatWindow;

	[HideInInspector]
	public BeatType beatMask;

	private void Start()
	{
	}

	public void BeatNotify(BeatType beatType)
	{
	}

	public void BeatNotify()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitOnBeat_003Ed__5))]
	private IEnumerator WaitOnBeat(BeatType beatType)
	{
		return null;
	}
}
