using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Costumes;
using Femur;
using TMPro;
using UnityEngine;

public class VoiceBubble : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CShowBubble_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VoiceBubble _003C_003E4__this;

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
		public _003CShowBubble_003Ed__14(int _003C_003E1__state)
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

	public CostumeCustomization CostumeCustomization;

	public TextMeshProUGUI VoiceText;

	public float ScaleSpeed;

	private Actor.Voice _currentVoice;

	private bool _scaleIn;

	private float _showTimeLeft;

	[SerializeField]
	private float _showTime;

	private float _scaleTime;

	private Vector3 _vector3zero;

	private Vector3 _vector3one;

	private Coroutine _coroutine_ShowBubble;

	private void Start()
	{
	}

	public void OnVoiceDeselect()
	{
	}

	public void OnVoiceSelect()
	{
	}

	[IteratorStateMachine(typeof(_003CShowBubble_003Ed__14))]
	private IEnumerator ShowBubble()
	{
		return null;
	}

	private void Update()
	{
	}

	public void TriggerSpeechBubble()
	{
	}

	public void CloseSpeechBubble()
	{
	}

	private void UpdateVoice()
	{
	}
}
