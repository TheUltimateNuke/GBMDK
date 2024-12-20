using UnityEngine;
using UnityEngine.UI;

public class PlaylistElementDataHolder : MonoBehaviour
{
	public delegate void OnPlaylistButtonPressed(PlaylistElementDataHolder elementHolder);

	[HideInInspector]
	public string RotationCupName;

	public Text CupTitle;

	public Text[] CupStageElements;

	public Button button;

	private OnPlaylistButtonPressed OnButtonPressEvent;

	private void Awake()
	{
	}

	public void RegisterButtonEvent(OnPlaylistButtonPressed callback)
	{
	}

	public void DeRegisterButtonEvent(OnPlaylistButtonPressed callback)
	{
	}

	private void OnButtonPress()
	{
	}

	public void EmptyUI()
	{
	}
}
