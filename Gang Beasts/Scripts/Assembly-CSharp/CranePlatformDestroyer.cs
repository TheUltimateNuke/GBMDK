using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

public class CranePlatformDestroyer : MonoBehaviour
{
	[Serializable]
	public class DestroyGroup
	{
		public List<DestroyData> data;

		public float Delay;
	}

	[Serializable]
	public class DestroyData
	{
		public Rigidbody rigidBody;

		public Joint[] joints;
	}

	[CompilerGenerated]
	private sealed class _003CBreakJointsLogic_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CranePlatformDestroyer _003C_003E4__this;

		private float _003CvelMult_003E5__2;

		private DestroyGroup _003CcurrDest_003E5__3;

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
		public _003CBreakJointsLogic_003Ed__32(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CPlayCreakingSounds_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CPlayCreakingSounds_003Ed__33(int _003C_003E1__state)
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

	[SerializeField]
	public List<DestroyGroup> Destroyables;

	public float minVelocityMult;

	public float maxVelocityMult;

	public float breakingJointsVolume;

	public float minBreakGap;

	public float maxBreakGap;

	public AudioMixerGroup mixerGroup;

	private float breakTimer;

	private float breakTime;

	public SceneAudioClip creakingSound;

	public AudioClip[] creakingAudioClips;

	public Transform breakingPosition;

	public AudioClip[] breakingAudioClips;

	private List<Joint> otherJoints;

	public Rigidbody[] otherJointsBody;

	public float minVariance;

	public float maxVariance;

	private bool hasTriggered;

	private bool lastBreakHappend;

	private bool playCreakingSoundsOnce;

	private bool ready;

	private int breakIndex;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider collider)
	{
	}

	private void DelayGetJoints()
	{
	}

	private void BreakJoint(Joint target, Rigidbody body, bool playAudio = false, bool setAngular = false, float velocityMultiplier = 2f)
	{
	}

	private void BreakJoint(Joint target, bool playAudio = false, bool setAngular = false)
	{
	}

	[ContextMenu("Break")]
	private void BreakStairs()
	{
	}

	[IteratorStateMachine(typeof(_003CBreakJointsLogic_003Ed__32))]
	private IEnumerator BreakJointsLogic()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayCreakingSounds_003Ed__33))]
	private IEnumerator PlayCreakingSounds()
	{
		return null;
	}

	private void BreakRandomJoint()
	{
	}

	private void PopulateOtherJoints()
	{
	}
}
