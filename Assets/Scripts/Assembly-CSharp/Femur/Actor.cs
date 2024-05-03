using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Costumes;
using GB.NetworkedInput;
using GB.Networking.Objects;
using UnityEngine;
using UnityEngine.InputSystem.Users;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace Femur
{
	public class Actor : NetworkBehaviour
	{
		public static class PushVolumeCacher
		{
			private static List<PushVolume> _volumeCache;

			public static List<PushVolume> Volumes => null;

			public static void RegisterPushVolume(PushVolume volume)
			{
			}

			public static void DeregisterPushVolume(PushVolume volume)
			{
			}
		}

		public enum DeathType
		{
			Default = 0,
			Falling = 1
		}

		public enum Voice
		{
			TUM = 0,
			DOF = 1,
			GOO = 2,
			BOO = 3,
			DEE = 4,
			OOK = 5,
			OLO = 6,
			YEE = 7,
			HUG = 8,
			UYU = 9,
			WUB = 10,
			YUP = 11,
			NPC_01 = 12,
			NPC_02 = 13,
			NPC_03 = 14,
			NPC_04 = 15
		}

		public enum ControlledTypes
		{
			Animation = 0,
			AI = 1,
			Human = 2
		}

		public enum ActorState
		{
			Dead = 1,
			Unconscious = 2,
			Stand = 4,
			Run = 8,
			Jump = 0x10,
			Fall = 0x20,
			Climb = 0x40,
			Swim = 0x80
		}

		public delegate void ActorStateHandler(Actor actor, int connectionID, ActorState state);

		public delegate void GangIDChanged(int newID);

		public delegate void ActorSetup(Actor actor);

		public delegate void SetPrimaryColor(Color value);

		public bool isTrackedByCamera;

		private bool hasTriggeredBudBud;

		[SerializeField]
		public bool _overrideNetworkAuthority;

		[SerializeField]
		private bool _overrideDummyActor;

		[SerializeField]
		private int _playerID;

		[SerializeField]
		[SyncVar(hook = "OnGangIDChanged")]
		private int _gangID;

		[SerializeField]
		private CostumeSaveEntryStruct _fallbackCostume;

		[SyncVar]
		private bool _aiMember;

		[SyncVar(hook = "ControllerIDChanged")]
		private int _controllerID;

		[SerializeField]
		private Color _primaryColor;

		[SerializeField]
		private Color _costumeColor;

		[Tooltip("This color feild will only work during runtime.")]
		[SerializeField]
		private Color _userSelectableColor;

		private ControlledTypes _controlledBy;

		public InputUser InputPlayer;

		public Voice voice;

		[HideInInspector]
		public bool RandomVoice;

		public GameObject TrackerObject;

		public GameObject TrackingCanvas;

		private ActorCostume _CostumeCompRef;

		private bool _drawBeast;

		private List<SkinnedMeshRenderer> _beastRendersSkin;

		private List<MeshRenderer> _beastRendersBase;

		public float groundSpeed;

		public float liftStrength;

		public float applyedForce;

		public float inputSpamForceModifier;

		public bool initialized;

		public bool showForces;

		public DeathType deathType;

		public VoicePack[] voicePack;

		private List<Collider> _costumeColliderCache;

		private bool _bodySetup;

		private float lastActorStateChange;

		[SyncVar(hook = "OnClientStateChange")]
		private ActorState _actorState;

		private static List<Actor> _LocalActors;

		private static List<Actor> _RemoteActors;

		private static List<Actor> _ActorCache;

		public float _punchDamageModifer;

		public float _punchForceModifer;

		public ControlHandeler controlHandeler;

		[HideInInspector]
		public TargetingHandeler targetingHandeler;

		[HideInInspector]
		public BodyHandeler bodyHandeler;

		[HideInInspector]
		public MovementHandeler movementHandeler;

		[HideInInspector]
		public StatusHandeler statusHandeler;

		[HideInInspector]
		public EffectsHandeler effectsHandeler;

		[HideInInspector]
		public GameModeHandeler gameModeHandeler;

		[HideInInspector]
		public InputState inputHandler;

		private const string NAMEBAR_PATH = "NameBar";

		private NameBarHandler _nameBarHandler;

		private bool _setupActorComplete;

		public AIProfile _aiProfile;

		public bool initializeOnStart;

		public bool IgnoreNetworkSetup;

		public ActorState lastActorState;

		public bool IsAI
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsLocal => false;

		public ActorCostume CostumeCompRef => null;

		public bool DrawBeast
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ActorState actorState
		{
			get
			{
				return default(ActorState);
			}
			set
			{
			}
		}

		public static List<Actor> LocalPlayers => null;

		public static List<Actor> RemoteActors => null;

		public static List<Actor> CachedActors => null;

		public NameBarHandler NameBar => null;

		public int playerID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int gangID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int controllerID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ControlledTypes ControlledBy
		{
			get
			{
				return default(ControlledTypes);
			}
			set
			{
			}
		}

		public Color primaryColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color CostumeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color UserSelectableColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public CostumeSaveEntry Costume
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Network_gangID
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		public bool Network_aiMember
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		public int Network_controllerID
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		public ActorState Network_actorState
		{
			get
			{
				return default(ActorState);
			}
			[param: In]
			set
			{
			}
		}

		public static event ActorStateHandler OnActorStateChangedServer
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

		public static event ActorStateHandler OnActorStateChangedClient
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

		public static event Action<Actor> OnActorSetup
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

		public static event Action<Actor> OnActorDestroyed
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

		public event GangIDChanged OnGangIDUpdated
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

		public static event ActorSetup OnNewActorSetup
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

		public event SetPrimaryColor OnPrimaryColorSet
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

		public event SetPrimaryColor OnCostumeColorChanged
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

		public static Voice GetRandomVoice(bool player = true, bool ai = false)
		{
			return default(Voice);
		}

		public static Voice GetVoiceFromString(string value)
		{
			return default(Voice);
		}

		public static string GetVoiceString(Voice value)
		{
			return null;
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static void FlushEvent()
		{
		}

		public void OnClientStateChange(ActorState value)
		{
		}

		public void ControllerIDChanged(int value)
		{
		}

		private void OnGangIDChanged(int value)
		{
		}

		private void PrimaryColorChanged(Color value)
		{
		}

		public void ForceResetCostumeColour()
		{
		}

		public void TweakAllRBs()
		{
		}

		private void TweakRB(Rigidbody body)
		{
		}

		public void Awake()
		{
		}

		private void ClearRendererCache()
		{
		}

		private void ApplyDrawBeast()
		{
		}

		private void OnSceneChanged(Scene prevScene, Scene newScene)
		{
		}

		private void DisableColliders()
		{
		}

		private void LocalKinematicSetter()
		{
		}

		private void CollectCostumeColliders()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void DressBeast()
		{
		}

		private void FallbackDress()
		{
		}

		public void Start()
		{
		}

		private void OnHeldBeastAdded(NetBeast beast)
		{
		}

		private void OnHeldBeastUpdated(NetBeast beast)
		{
		}

		private void OnHeldBeastRemoved(NetBeast beast)
		{
		}

		private void UpdateNetBeast(NetBeast beast)
		{
		}

		private void UpdateStatusHandlerPlatform(NetBeast beast)
		{
		}

		private void UpdateCostume(NetBeast beast)
		{
		}

		public void OnDestroy()
		{
		}

		public override void OnStartLocalPlayer()
		{
		}

		public override void OnStartServer()
		{
		}

		public void Setup()
		{
		}

		public void GetRefrences()
		{
		}

		public void SetupBodyHandeler()
		{
		}

		public void SetupReceivedCostumeColour()
		{
		}

		public void SetupActor()
		{
		}

		public void SetDebugMode(bool state)
		{
		}

		public Transform GetTrackingTransform()
		{
			return null;
		}

		public void Update()
		{
		}

		public void FixedUpdate()
		{
		}

		public void Laugh()
		{
		}

		public void BudBud()
		{
		}

		private void UpdateState()
		{
		}

		private void Targeting()
		{
		}

		public void SetupTargetingSphere(Transform upperTargeter, Transform lowerTargeter, Transform parent, float size)
		{
		}

		public void ForceSetColors()
		{
		}

		public void SetColor(string meterialID, Color color)
		{
		}

		private void AssignControlHandler()
		{
		}

		private void UNetVersion()
		{
		}

		public override bool OnSerialize(NetworkWriter writer, bool forceAll)
		{
			return false;
		}

		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
		}

		public override void PreStartClient()
		{
		}
	}
}
