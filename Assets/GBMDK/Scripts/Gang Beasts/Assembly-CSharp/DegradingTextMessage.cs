using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Networking.Messaging.Messages;
using GB.View.UI;
using TMPro;
using UnityEngine;

public class DegradingTextMessage : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRunLife_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DegradingTextMessage _003C_003E4__this;

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
		public _003CRunLife_003Ed__12(int _003C_003E1__state)
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

	private float _lifeTimer;

	private float _fadeTimer;

	[SerializeField]
	private TextMeshProUGUI _textComp;

	[SerializeField]
	private Canvas _canvas;

	[SerializeField]
	private UIControllerFallback _vrFallback;

	[SerializeField]
	private float _uiDeapth;

	private Vector3 _cachedOffset;

	private Coroutine activeMoveRoutine;

	private bool _worldSpace;

	public void StartLife(NetServerMessage message)
	{
	}

	public void StartLife(string customMessage, Color colour)
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CRunLife_003Ed__12))]
	private IEnumerator RunLife()
	{
		return null;
	}

	private void Cleanup()
	{
	}

	private void OnAnchorChanged()
	{
	}

	private void Update()
	{
	}

	private void UpdateRotation()
	{
	}

	private void UpdatePosition()
	{
	}
}
