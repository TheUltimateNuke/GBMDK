using Cinemachine;
using Femur;
using GB.View.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.SceneManagement;

public class CameraTrackingHandler : MonoBehaviour
{
	public GameObject spectatingUI;

	public UIController spectatingUIController;

	private int trackedPlayerIndex;

	public float SpectatingLabelDuration;

	private bool showingSpectatingLabel;

	private float timer;

	private float animFadeDuration;

	private bool scanRight;

	private bool overrideVisible;

	public Transform SpectatingTarget;

	private Actor _SpectatingTarget;

	private bool _SpectatingAll;

	private CMTargetGroupHandler _TargetGroupHandler;

	private CMTargetGroupPool _TargetGroups;

	private bool _BlockShowingLabel;

	private TextMeshProUGUI _SpectatingText;

	private LocalizeStringEvent _SpectatingLocStringEvent;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void Reset()
	{
	}

	private void Update()
	{
	}

	private void SetSpectatingText(bool showSpectating)
	{
	}

	private void OnLocalBeastsDead(CinemachineTargetGroup.Target t)
	{
	}

	private bool TryTrackLocalPlayers()
	{
		return false;
	}

	private void OnClientDisconnect(string reason)
	{
	}

	public void SetSpecatatingTextEnabled(bool enabled)
	{
	}

	private void SetSpectatingLabel(string text, bool overrideDuration = false)
	{
	}

	private void ShowActorName(Actor actor = null, bool showAll = false)
	{
	}

	private void HideActorName(Actor actor)
	{
	}

	private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
	{
	}

	private void CheckValidInCurrentScene()
	{
	}
}
