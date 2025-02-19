using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
	[NetworkSettings(channel = 0, sendInterval = 0f)]
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
			Swim = 0x80,
			Drive = 0x100,
			Idle = 0x200
		}

		public delegate void ActorStateHandler(Actor actor, int connectionID, ActorState state);

		public delegate void GangIDChanged(int newID);

		public delegate void ActorSetup(Actor actor);

		public delegate void SetPrimaryColor(Color value);

		[CompilerGenerated]
		private sealed class _003CDressBeast_003Ed__150 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Actor _003C_003E4__this;

			private NetBeast _003Cbeast_003E5__2;

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
			public _003CDressBeast_003Ed__150(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CFallbackDress_003Ed__151 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Actor _003C_003E4__this;

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
			public _003CFallbackDress_003Ed__151(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CStart_003Ed__152 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Actor _003C_003E4__this;

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
			public _003CStart_003Ed__152(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CUpdateNetBeatInternal_003Ed__157 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Actor _003C_003E4__this;

			public NetBeast beast;

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
			public _003CUpdateNetBeatInternal_003Ed__157(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CUpdateCostume_003Ed__159 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Actor _003C_003E4__this;

			public NetBeast beast;

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
			public _003CUpdateCostume_003Ed__159(int _003C_003E1__state)
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

		private const float TARGET_UPDATE_FREQ = 0.5f;

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

		private Coroutine _coroutineUpdateNetBeast;

		public AIProfile _aiProfile;

		public bool initializeOnStart;

		public bool IgnoreNetworkSetup;

		private float timeSinceTarget;

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

		public CostumeSaveEntry Costume => null;

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

		public NetBeast GetAssociatedNetBeast()
		{
			return null;
		}

		public uint GetNetIdentityValue()
		{
			return 0u;
		}

		[IteratorStateMachine(typeof(_003CDressBeast_003Ed__150))]
		public IEnumerator DressBeast()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFallbackDress_003Ed__151))]
		private IEnumerator FallbackDress()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__152))]
		public IEnumerator Start()
		{
			return null;
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

		[IteratorStateMachine(typeof(_003CUpdateNetBeatInternal_003Ed__157))]
		private IEnumerator UpdateNetBeatInternal(NetBeast beast)
		{
			return null;
		}

		private void UpdateStatusHandlerPlatform(NetBeast beast)
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateCostume_003Ed__159))]
		private IEnumerator UpdateCostume(NetBeast beast)
		{
			return null;
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

		public override float GetNetworkSendInterval()
		{
			return 0f;
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
