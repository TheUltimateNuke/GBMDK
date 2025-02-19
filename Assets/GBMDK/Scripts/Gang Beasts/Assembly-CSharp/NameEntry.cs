using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class NameEntry : MonoBehaviour
{
	public delegate void NameReturned(string name);

	public delegate void BackPressed();

	[CompilerGenerated]
	private sealed class _003CSetInputFeildSelection_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NameEntry _003C_003E4__this;

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
		public _003CSetInputFeildSelection_003Ed__14(int _003C_003E1__state)
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

	public InputField InputFieldRef;

	public Button OkButton;

	public Button BackButton;

	private NameReturned _nameReturned;

	private BackPressed _backPressed;

	private string _returnedInputFeildValue;

	public void Start()
	{
	}

	public void Activate(NameReturned nameReturned, BackPressed backPressed, string savedName = "")
	{
	}

	public void GetName(string inputFeildValue)
	{
	}

	public void ReturnName()
	{
	}

	public void PressedBack()
	{
	}

	public void InputFeildSelected()
	{
	}

	[IteratorStateMachine(typeof(_003CSetInputFeildSelection_003Ed__14))]
	public IEnumerator SetInputFeildSelection()
	{
		return null;
	}
}
