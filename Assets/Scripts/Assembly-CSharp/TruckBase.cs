using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.DebugTools;
using UnityEngine;

public class TruckBase : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBumpDelay_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TruckBase _003C_003E4__this;

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
		public _003CBumpDelay_003Ed__24(int _003C_003E1__state)
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

	private Transform thisTransform;

	private Rigidbody thisRigidbody;

	public float force;

	public Vector3 min;

	public Vector3 max;

	public bool outOfBounds;

	public int seed;

	private Vector3 startPos;

	[ReferenceDebugVariable(null, null, DebugVariables.DebugVariableCheckMode.None, updateMode = DebugVariables.DebugVariableCheckMode.PerFrame)]
	private Vector3 direction;

	public Rigidbody[] AttachedWheels;

	public float BumpFakeMinTime;

	public float BumpFakeMaxTime;

	public float BumpFakeForceMin;

	public float BumpFakeForceMax;

	private float nextBumpFakeTime;

	private float currentBumpFakeTime;

	private bool _Initialized;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void FixedUpdate()
	{
	}

	private void HandleFakeBump()
	{
	}

	public void NewDirection()
	{
	}

	public void AlignToVector(Rigidbody part, Vector3 alignmentVector, Vector3 targetVector, float stability, float speed)
	{
	}

	private void OnGameStart()
	{
	}

	[IteratorStateMachine(typeof(_003CBumpDelay_003Ed__24))]
	private IEnumerator BumpDelay()
	{
		return null;
	}
}
