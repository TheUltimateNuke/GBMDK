using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[SingularComponent]
public class RandomBreak : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBreakApplyForce_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RandomBreak _003C_003E4__this;

		public float impulseMultiplier;

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
		public _003CBreakApplyForce_003Ed__22(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CBreakRoutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitSeconds;

		public RandomBreak _003C_003E4__this;

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
		public _003CBreakRoutine_003Ed__23(int _003C_003E1__state)
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

	[SerializeField]
	private float minBreakTime;

	[SerializeField]
	private float maxBreakTime;

	[SerializeField]
	private AnimationCurve timeWeightingCurve;

	[SerializeField]
	private bool _applyRandomTorqueOnBreak;

	[SerializeField]
	private bool _applyRandomVelocityOnBreak;

	[SerializeField]
	private float _randomTorqueMagnitude;

	[SerializeField]
	private float _randomVelocityManitude;

	[SerializeField]
	private AudioClip[] _breakNoiseClips;

	[SerializeField]
	private float _breakNoisePitchMin;

	[SerializeField]
	private float _breakNoisePitchMax;

	[SerializeField]
	private float _breakNoiseVolume;

	[SerializeField]
	private float _breakNoiseMaxDistance;

	private bool _broken;

	public Wheel Wheel;

	[HideInInspector]
	public List<Joint> ConnectedJoints;

	public bool IsBackFacing;

	public float ImpulseMagnitude;

	private Rigidbody _rigidbody;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[ContextMenu("Break")]
	public void Break(float impulseMultiplier = 1f)
	{
	}

	private void OnJointBreak(float breakForce)
	{
	}

	[IteratorStateMachine(typeof(_003CBreakApplyForce_003Ed__22))]
	private IEnumerator BreakApplyForce(float impulseMultiplier)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBreakRoutine_003Ed__23))]
	private IEnumerator BreakRoutine(float waitSeconds)
	{
		return null;
	}
}
