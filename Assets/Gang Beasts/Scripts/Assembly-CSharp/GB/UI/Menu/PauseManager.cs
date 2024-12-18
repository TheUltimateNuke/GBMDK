using System;
using System.Runtime.CompilerServices;
using CoreNet.Messaging.Messages;
using CoreNet.Objects;
using GB.Game;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GB.UI.Menu
{
	public class PauseManager : MenuController
	{
		public GameObject pauseGO;

		public GameObject restartButton;

		private static PauseManager instance;

		public static GameManagerNew gameManager;

		public static bool paused;

		private bool disablePause;

		private bool blockPause;

		private NetBoolMessage NetPauseState;

		private float timescaleChangeTime;

		private float togglePauseTimeout;

		private float toggleTimer;

		private string uiCameraResource;

		private GameObject uiCamera;

		private static float DEFAULT_PAUSE_BLUR_TIME;

		[SerializeField]
		protected BaseMenuScreen SysMessageScreen;

		[SerializeField]
		protected TextMeshProUGUI SysMessageText;

		public bool isShowingSystemMessage;

		[SerializeField]
		private float _uiVRForwardMultiplier;

		public static PauseManager Instance => null;

		public bool IsPaused => false;

		public bool PauseAllowed => false;

		public static event Action OnPauseToggled
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

		public void Awake()
		{
		}

		public new void Start()
		{
		}

		private void OnGameManagerCreated()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnNetworkStarted()
		{
		}

		private void RegisterForMessages()
		{
		}

		private void RegisterWithModel()
		{
		}

		private void OnStateChange(NetInt currentState)
		{
		}

		private void EnsureNoPause()
		{
		}

		private void OnPauseblockerStarted()
		{
		}

		private void OnPauseblockerEnded()
		{
		}

		private new void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void MatchAnchorLocation()
		{
		}

		private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		private void CheckPauseValidInCurrentScene()
		{
		}

		public void Update()
		{
		}

		public void SetPaused(bool active)
		{
		}

		private void InternalSetPause(bool setTo)
		{
		}

		private void PauseWasToggled()
		{
		}

		public void ResetPause()
		{
		}

		public void ShowMessage(string key)
		{
		}

		public void CompleteQuitGame()
		{
		}

		public void OnReturnToMenu()
		{
		}

		public void OnRestartRound()
		{
		}
	}
}
