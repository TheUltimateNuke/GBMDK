using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CursorManagement : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMouseAutoHide_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CursorManagement _003C_003E4__this;

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
		public _003CMouseAutoHide_003Ed__9(int _003C_003E1__state)
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

	public bool Enabled;

	public float DelayUntilHide;

	public Texture2D cursorTexture;

	public CursorMode cursorMode;

	public Vector2 hotSpot;

	private float idleMouseTime;

	private Vector2 lastMousePosition;

	public void Start()
	{
	}

	public void Enable(bool enable)
	{
	}

	[IteratorStateMachine(typeof(_003CMouseAutoHide_003Ed__9))]
	private IEnumerator MouseAutoHide()
	{
		return null;
	}

	public void SetLocked(bool locked)
	{
	}
}
