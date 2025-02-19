using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Costumes;
using Femur;
using UnityEngine;
using UnityEngine.EventSystems;

public class VoiceSelection : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CChangeVoiceRoutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MoveDirection dir;

		public VoiceSelection _003C_003E4__this;

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
		public _003CChangeVoiceRoutine_003Ed__14(int _003C_003E1__state)
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

	public ControllerButtons ControllerButtons;

	public EffectsHandeler.VoiceType PreviewType;

	public Actor.Voice DefaultVoice;

	public Actor.Voice[] AllowedVoices;

	public bool ForceActorEmotes;

	public SelectedMenuInputEvent selectedMenuInputEvent;

	private EffectsHandeler EffectsHandeler;

	private void Awake()
	{
	}

	private void Selected()
	{
	}

	private void Start()
	{
	}

	public void Update()
	{
	}

	public void ResetVoice()
	{
	}

	private void ChangeVoice(MoveDirection dir)
	{
	}

	[IteratorStateMachine(typeof(_003CChangeVoiceRoutine_003Ed__14))]
	private IEnumerator ChangeVoiceRoutine(MoveDirection dir)
	{
		return null;
	}

	private Actor.Voice GetNextAllowedVoice(Actor.Voice voice, bool previous = false)
	{
		return default(Actor.Voice);
	}

	private bool IsValidVoice(Actor.Voice voice)
	{
		return false;
	}
}
