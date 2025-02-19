using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Gamemodes;
using UnityEngine;

public class OnTriggerStayUnlockRotation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCloseDoor_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnTriggerStayUnlockRotation _003C_003E4__this;

		private bool _003Ctest_003E5__2;

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
		public _003CCloseDoor_003Ed__22(int _003C_003E1__state)
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

	public float MinRotation;

	public float MaxRotation;

	public float targetStartRotation;

	public bool StartLocked;

	public HingeJoint TargetJoint;

	private int hasTriggered;

	private JointLimits targetLimits;

	public GameModeEnum validGameMode;

	private bool isActive;

	private bool doorUnlocked;

	[SerializeField]
	private float _waitOpenTime;

	private WaitForSeconds _waitTime;

	private Coroutine _closeCheck;

	private int HasTriggered
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void CalculateJointLimits(int shouldUnlock)
	{
	}

	private void SetJoinLimits()
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

	[IteratorStateMachine(typeof(_003CCloseDoor_003Ed__22))]
	private IEnumerator CloseDoor()
	{
		return null;
	}
}
