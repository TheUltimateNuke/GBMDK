using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SuperGenius.Scripts.Audio.ScriptableObjects;
using UnityEngine;

public class FractureShard : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDelayCheckJointBreaks_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FractureShard _003C_003E4__this;

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
		public _003CDelayCheckJointBreaks_003Ed__21(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCleanupRoutine_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FractureShard _003C_003E4__this;

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
		public _003CCleanupRoutine_003Ed__25(int _003C_003E1__state)
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

	public SoundEffectScriptable JointBreakSound;

	public bool CleanUp;

	public float MinCleanupDelay;

	public float MaxCleanupDelay;

	public bool CleanupEffect;

	public ParticleSystem CleanupParticleSystem;

	public SoundEffectScriptable _cleanupSoundEffectScriptable;

	private List<Joint> _jointList;

	private List<FractureShard> _connectedShard;

	private List<Joint> _connectedJoints;

	private bool _cleaningUp;

	private Coroutine _delayJointBreakCheck;

	private const int _fixedUpdatedToDelay = 2;

	private int _delayFixedUpdatedCount;

	private static int _lastBreakFrame;

	private void OnEnable()
	{
	}

	private void OnJointBreak(float breakForce)
	{
	}

	public void AddJoint(Joint joints)
	{
	}

	public void EvaluateJoints()
	{
	}

	private void Init()
	{
	}

	private void CollectJoints()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayCheckJointBreaks_003Ed__21))]
	private IEnumerator DelayCheckJointBreaks()
	{
		return null;
	}

	private void CheckJointBreaks()
	{
	}

	private void StartCleanup()
	{
	}

	private void PlayBreakSound()
	{
	}

	[IteratorStateMachine(typeof(_003CCleanupRoutine_003Ed__25))]
	private IEnumerator CleanupRoutine()
	{
		return null;
	}

	private void FinalizeCleanUp()
	{
	}
}
