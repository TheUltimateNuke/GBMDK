using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Gamemodes;
using UnityEngine;

public class OnTriggerStayApplyForce : MonoBehaviour
{
	public enum ForceType
	{
		Linear = 0,
		Torque = 1
	}

	[CompilerGenerated]
	private sealed class _003CCloseDoor_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnTriggerStayApplyForce _003C_003E4__this;

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
		public _003CCloseDoor_003Ed__17(int _003C_003E1__state)
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

	public Vector3 openForce;

	public Vector3 closeForce;

	public ForceType forceType;

	public GameModeEnum validGameMode;

	public Rigidbody target;

	private bool doorOpen;

	private int hasTriggered;

	private bool isActive;

	[SerializeField]
	private float _waitOpenTime;

	private WaitForSeconds _waitTime;

	private Coroutine _closeCheck;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnTriggerEnter(Collider collider)
	{
	}

	private void OnTriggerExit(Collider collider)
	{
	}

	private void StartCloseCheck()
	{
	}

	[IteratorStateMachine(typeof(_003CCloseDoor_003Ed__17))]
	private IEnumerator CloseDoor()
	{
		return null;
	}
}
