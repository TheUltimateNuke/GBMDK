using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

[RequireComponent(typeof(TextMeshProUGUI))]
public class CostumeEditButton : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUpdateText_Routine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int index;

		public CostumeEditButton _003C_003E4__this;

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
		public _003CUpdateText_Routine_003Ed__9(int _003C_003E1__state)
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

	public LocalizedString EditString;

	public LocalizedString NewString;

	public LocalizeStringEvent localizeControl;

	public SaveSelection SaveSelection;

	private bool _isEditText;

	private Button button;

	public GameObject savesFullUI;

	private void Awake()
	{
	}

	private void UpdateButton(int index)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateText_Routine_003Ed__9))]
	private IEnumerator UpdateText_Routine(int index)
	{
		return null;
	}

	private void UpdateButtonText(LocalizedString newText)
	{
	}
}
