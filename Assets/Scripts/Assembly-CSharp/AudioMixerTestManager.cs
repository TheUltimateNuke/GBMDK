using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

public class AudioMixerTestManager : MonoSingleton<AudioMixerTestManager>
{
	[Serializable]
	public class AudioData
	{
		public AudioClip clip;

		public float tempo;
	}

	[CompilerGenerated]
	private sealed class _003CUpdateWeights_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioMixerTestManager _003C_003E4__this;

		public bool toRight;

		private float _003CtrackTransitionLength_003E5__2;

		private float _003CdrumTransitionLength_003E5__3;

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
		public _003CUpdateWeights_003Ed__47(int _003C_003E1__state)
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

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }

	[SerializeField]
	private List<AudioData> _audioData;

	[SerializeField]
	private AudioSource leftA;

	[SerializeField]
	private AudioSource leftB;

	[SerializeField]
	private AudioSource leftDrums;

	[SerializeField]
	private AudioSource rightA;

	[SerializeField]
	private AudioSource rightB;

	[SerializeField]
	private AudioSource rightDrums;

	[SerializeField]
	private AudioMixerSnapshot bothDrums;

	[SerializeField]
	private AudioMixerSnapshot bothTracks;

	[SerializeField]
	private AudioMixer DJMixer;

	[SerializeField]
	[Space(10f)]
	private float tempoLeft;

	[SerializeField]
	private float tempoRight;

	[SerializeField]
	[Space(10f)]
	private float trackTransitionTimeInBars;

	[SerializeField]
	private float drumTransitionTimeInBars;

	[SerializeField]
	private float drumTransitionTimeMultiplier;

	[SerializeField]
	private float trackTransitionTimeMultiplier;

	[SerializeField]
	private BeatObserver leftBeatObserver;

	[SerializeField]
	private BeatObserver rightBeatObserver;

	[SerializeField]
	private BeatCounter leftBeatCounter;

	[SerializeField]
	private BeatCounter rightBeatCounter;

	[SerializeField]
	private BeatSynchronizer leftBeatSynchronizer;

	[SerializeField]
	private BeatSynchronizer rightBeatSynchronizer;

	[Space(10f)]
	public bool StartTransitionFakeButton;

	private bool leftSidePlaying;

	private bool trackplaying;

	private float bothDrumWeight;

	private float bothTrackWeight;

	private float bothDrumWeightTarget;

	private float bothTracksWeightTarget;

	private float lTargetTrackSpeed;

	private float rTargetTrackSpeed;

	private float tDrum;

	private float tTrack;

	private float[] weights;

	private AudioMixerSnapshot[] snaps;

	[HideInInspector]
	public bool beatDetected;

	[HideInInspector]
	public bool waitingForBeat;

	private void Awake()
	{
	}

	private AudioClip[] GetAllSongsInProject()
	{
		return null;
	}

	private float GetBeatLengthInSeconds(float tempo)
	{
		return 0f;
	}

	private float GetNewTrackSpeed(float startingTempo, float endingTempo)
	{
		return 0f;
	}

	private void Update()
	{
	}

	private void Start()
	{
	}

	private void BeginTransition()
	{
	}

	private void UpdateSnapshots(float trackTransitionLength, float drumTransitionLength)
	{
	}

	public void BeatDetected()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateWeights_003Ed__47))]
	private IEnumerator UpdateWeights(bool toRight)
	{
		return null;
	}
}
