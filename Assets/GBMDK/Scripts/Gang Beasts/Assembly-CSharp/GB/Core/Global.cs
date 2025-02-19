using System.Runtime.CompilerServices;
using CoreNet;
using CoreNet.Model;
using CoreNet.Threading;
using Costumes;
using GB.Core.Loading;
using GB.Core.UI;
using GB.Data.Loading;
using GB.Input;
using GB.Menu;
using GB.Platform;
using GB.Platform.UI;
using GB.Setup;
using GB.UI;
using GB.UI.CoinScreen;
using GB.UnityServices.Matchmaking;
using GB.View.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GB.Core
{
	public class Global : MonoSingleton<Global>, IDeferredActivator
	{
		public delegate void Handler();

		public delegate void SceneHandler(string name);

		public static bool StartupSequenceComplete;

		public static bool Initialised;

		public static readonly string MENU_SCENE_NAME;

		public static ushort NetworkMaxPlayers;

		private NetModel _Model;

		private UIDirector _UIDirector;

		[SerializeField]
		private LocalizationLoader _localizationLoader;

		[SerializeField]
		private SceneLoader _sceneLoader;

		[SerializeField]
		private ResourceLoader _resourceLoader;

		private NetworkManager _UNetManager;

		public GameObject NetworkObjectPrefab;

		private GameObject NetworkObjRef;

		public Text ServerBetaPanel;

		public GraphicsManager Graphics;

		public UIManager UIManager;

		public BoundUIController BoundUIParent;

		public CostumePool Costumes;

		public UnityThreadHandler ThreadHandler;

		public EntitlementMenu EntitlementMenuOverlay;

		public LoadScreenSystem LevelLoadSystem;

		public ActorDeathAudio ActorDeathAudioHandler;

		public CameraTrackingHandler cameraTrackingHandler;

		public CoinScreenHandler CoinScreenHandler;

		public Camera uiCamera;

		public GBUIInputHandler UIinputHandler;

		public PersistantButtonController buttonController;

		public MatchmakingClientMonobehaviour Matchmaking;

		private InputUserDataStorage _inputStorage;

		private GlobalCamera _GlobalCam;

		private PlatformManager _Platform;

		private DebugHandler _Debug;

		public NetModel Model => null;

		public UIDirector UIDirector => null;

		public LocalizationLoader LocalizationLoader => null;

		public SceneLoader SceneLoader => null;

		public ResourceLoader Resources => null;

		public NetworkManager UNetManager => null;

		public static float TimeSinceStartup { get; private set; }

		public InputUserDataStorage InputStorage => null;

		public GlobalCamera GlobalCam => null;

		public PlatformManager Platform => null;

		public DebugHandler Debug => null;

		public event Handler OnResetNetworkManager
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

		public event Handler OnResetScene
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

		public event SceneHandler OnChangeScene
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

		private void OnDestroy()
		{
		}

		public void BeginDeferredActivation()
		{
		}

		public bool HasFinishedDeferredActivation()
		{
			return false;
		}

		private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
		{
		}

		private void Update()
		{
		}

		public void ResetScene()
		{
		}

		public void ChangeScene(string name)
		{
		}

		public void SelfDestruct()
		{
		}

		private void FlushAllSubEvents()
		{
		}
	}
}
