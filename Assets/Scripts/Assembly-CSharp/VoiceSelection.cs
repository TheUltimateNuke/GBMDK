using Costumes;
using Femur;
using UnityEngine;
using UnityEngine.EventSystems;

public class VoiceSelection : MonoBehaviour
{
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

	private Actor.Voice GetNextAllowedVoice(Actor.Voice voice, bool previous = false)
	{
		return default(Actor.Voice);
	}

	private bool IsValidVoice(Actor.Voice voice)
	{
		return false;
	}
}
