using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SignBulbBreaker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBreakOuterBulbRoutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WaitForSeconds waitSeconds;

		public SignBulbBreaker _003C_003E4__this;

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
		public _003CBreakOuterBulbRoutine_003Ed__16(int _003C_003E1__state)
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
	private sealed class _003CBreakInnerBulbRoutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WaitForSeconds waitSeconds;

		public SignBulbBreaker _003C_003E4__this;

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
		public _003CBreakInnerBulbRoutine_003Ed__17(int _003C_003E1__state)
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

	public Material brokenMaterial;

	public GeneralAudioData bulbBreakAudioData;

	private bool broken1;

	private bool broken2;

	private Renderer thisRenderer;

	private ParticleSystem thisParticleSystem;

	private Material[] m_InnerBulbMaterials;

	private Material[] m_OuterBulbMaterials;

	private WaitForSeconds waitBreakOuterBulb;

	private WaitForSeconds waitBreakInnerBulb;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnGameStart()
	{
	}

	private void OnJointBreak(float breakForce)
	{
	}

	public void BreakOuterBulb()
	{
	}

	public void BreakInnerBulb()
	{
	}

	[IteratorStateMachine(typeof(_003CBreakOuterBulbRoutine_003Ed__16))]
	private IEnumerator BreakOuterBulbRoutine(WaitForSeconds waitSeconds)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBreakInnerBulbRoutine_003Ed__17))]
	private IEnumerator BreakInnerBulbRoutine(WaitForSeconds waitSeconds)
	{
		return null;
	}
}
