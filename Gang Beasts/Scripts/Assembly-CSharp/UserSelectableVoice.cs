using System.Collections.Generic;
using Costumes;
using Femur;
using UnityEngine;
using UnityEngine.UI;

public class UserSelectableVoice : MonoBehaviour
{
	public delegate void Callback();

	public CostumeCustomization CostumeCustomizationRefrence;

	public RectTransform Items;

	public RectTransform SelectableVoicePanel;

	public Button Back;

	public Button VoiceButtonPrefab;

	public MoveSelectedButtonTo MoveSelectedButtonTo;

	public Actor.Voice DefaultVoice;

	public Actor.Voice[] AllowedVoices;

	public VoicePack[] voicePack;

	public AudioSource AudioSource;

	private Callback _callback;

	private Button _lastActiveButton;

	private string _originalVoice;

	private List<Button> _voiceButtons;

	private void Start()
	{
	}

	public void SetupUserColorButtons()
	{
	}

	private void CreateVoiceButton(string voiceName)
	{
	}

	public void ActivateUserVoiceSelection(Callback callback)
	{
	}

	public void OnSelect(string voice)
	{
	}

	public void OnSubmit(string voice)
	{
	}

	public void OnCancel()
	{
	}

	public void OnExit()
	{
	}
}
