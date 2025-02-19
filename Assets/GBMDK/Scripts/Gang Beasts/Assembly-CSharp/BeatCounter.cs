using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SynchronizerData;
using UnityEngine;

public class BeatCounter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBeatCheck_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BeatCounter _003C_003E4__this;

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
		public _003CBeatCheck_003Ed__20(int _003C_003E1__state)
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

	public BeatValue beatValue;

	public float beatScalar;

	public BeatValue beatOffset;

	public bool negativeBeatOffset;

	public BeatType beatType;

	public float loopTime;

	public AudioSource audioSource;

	public GameObject[] observers;

	private float nextBeatSample;

	private float samplePeriod;

	private float sampleOffset;

	private float currentSample;

	private float unscaledSamplePeriod;

	private float unscaledSampleOffset;

	private float beatTime;

	public double GetNextBeatTime()
	{
		return 0.0;
	}

	private void Awake()
	{
	}

	private void StartBeatCheck(double syncTime)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CBeatCheck_003Ed__20))]
	private IEnumerator BeatCheck()
	{
		return null;
	}
}
