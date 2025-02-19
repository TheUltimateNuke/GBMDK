using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PushVolumeClient : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDegradeForce_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PushVolumeClient _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		private float _003CdelayTime_003E5__3;

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
		public _003CDegradeForce_003Ed__15(int _003C_003E1__state)
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

	public float forceOverrideMultiplier;

	[SerializeField]
	private bool degradeAfterFirstForce;

	[SerializeField]
	private float degradationDelayTime;

	[SerializeField]
	private float degradationDelayVariance;

	[SerializeField]
	private float degradationTime;

	private PushVolume[] volumes;

	[HideInInspector]
	public Rigidbody rb;

	[HideInInspector]
	public Transform t;

	public Transform[] floatPoints;

	private float startingMultiplier;

	private bool hasBeenForceAffected;

	private bool hasStartedDecaying;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void NotifyForceActive()
	{
	}

	[IteratorStateMachine(typeof(_003CDegradeForce_003Ed__15))]
	private IEnumerator DegradeForce()
	{
		return null;
	}

	private void OnDrawGizmosSelected()
	{
	}

	public bool HasStartedDecaying()
	{
		return false;
	}
}
