using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CoreNet.StateSync.Triggers;
using GB.Environment.Breakable;
using UnityEngine;

namespace GB.Stages.Wheel
{
	[SingularComponent]
	public class RandomPierBreak : BaseSyncTrigger, IBreakable
	{
		private static HashSet<Rigidbody> excludedWheelParts;

		private bool _isBroken;

		private Joint[] thisJoint;

		private Rigidbody thisRigidbody;

		[SerializeField]
		private List<RandomPierBreak> neighbours;

		[SerializeField]
		private List<PierBreakInfluence> influences;

		public bool _beAffectedByBeastsStanding;

		public bool _beAffectedByInfluences;

		public bool _beAffectedByDurationOfMatch;

		public float _baseBreakPotentialMin;

		public float _baseBreakPotentialMax;

		public float timeUntilFullBreakPotential;

		public float timePotentialBreakModifer;

		public float distancePotenrialBreakModifer;

		public float _dwellTimeUntilFullBreakPotentialMin;

		public float _dwellTimeUntilFullBreakPotentialMax;

		public float _dwellTimeLossPerSecond;

		public float _dwellTimeBreakModifer;

		public AudioClip[] _pierCreakAudioClips;

		public float _pierCreakAudioStartThreshold;

		public float _pierCreakAudioResetThreshold;

		public float _pierCreakAudioPitchMin;

		public float _pierCreakAudioPitchMax;

		public float _pierCreakAudioVolume;

		public AudioClip[] _pierBreakAudioClips;

		public float _pierBreakAudioPitchMin;

		public float _pierBreakAudioPitchMax;

		public float _pierBreakAudioVolume;

		public float _pierBreakDelay;

		private bool _pierCreakAudioPlayed;

		[SerializeField]
		private PierSoundRouter _pierSoundRouter;

		[SerializeField]
		private float _maxDwellTime;

		[SerializeField]
		private float _currentDwellTime;

		[SerializeField]
		private float _currentBasePotential;

		private float _checkPeriodInSeconds;

		private float _lastCheckTime;

		private float _roundRunningTime;

		private int _beastsStoodOn;

		private int _fallenNeighbours;

		private Vector3 averageLocalPosition;

		public bool IsBroken => false;

		private static bool JointsActive => false;

		public event IBreakable.BreakableEvent OnBroken
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void CheckCreakAudio(float potential)
		{
		}

		private void OnNeighbourFallen(IBreakable neighbour, object info)
		{
		}

		[ContextMenu("Break")]
		public void Break()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnCollisionExit(Collision collision)
		{
		}

		private bool StoodOn(Collision collision)
		{
			return false;
		}

		[ContextMenu("Gather Neighbours")]
		private void GatherNeighbours()
		{
		}

		private Vector3 GatherAveragePosition()
		{
			return default(Vector3);
		}

		public float CalculateInfluence(bool isPlaying = true)
		{
			return 0f;
		}

		public void PlayBreakSound()
		{
		}

		public void PlayBreakSound(int soundIndex, float pitch)
		{
		}

		public void PlayCreakSound()
		{
		}

		public void PlayCreakSound(int soundIndex, float pitch)
		{
		}
	}
}
