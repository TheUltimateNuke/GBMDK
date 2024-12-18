using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Coatsink.UnityServices.Matchmaking;
using GB.UI;
using GB.UI.Lobby;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlaylistMenuHandler : Selectable
{
	public enum MenuType
	{
		Local = 0,
		Online = 1
	}

	public MenuType type;

	public Text cupTypeValue;

	public BoolOptionHandler privateGame;

	public Transform playlistContainer;

	public StartGameCountdown localCountdown;

	public LobbyCountdown onlineCountdown;

	private PlaylistMenuConfig menuConfig;

	private string playlistElementPath;

	private List<PlaylistElementDataHolder> activePlaylistElements;

	private int activeMenuConfigIndex;

	private float sizeIncreasePercentOnSelect;

	private float sizeIncreaseWobbleOnSelect;

	private float sizeIncreaseWobbleSpeed;

	private Vector3 cachedStartingScale;

	private Transform cachedTransform;

	private PlaylistElementDataHolder selectedPlaylist;

	public static event Action OnPlaylistsPopulated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	protected override void Start()
	{
	}

	private void Update()
	{
	}

	protected override void OnDestroy()
	{
	}

	public override void OnMove(AxisEventData eventData)
	{
	}

	private void GenerateUI()
	{
	}

	public void OnCountdownComplete()
	{
	}

	private void OnPlaylistChoosen(PlaylistElementDataHolder dataHolder)
	{
	}

	private void SetupLoadScreen()
	{
	}

	private void SetConfigOnGameManager()
	{
	}

	private void SetupNetMemberContext()
	{
	}

	private void OnMatchmakingStateChanged(MatchmakingState matchmakingState)
	{
	}
}
