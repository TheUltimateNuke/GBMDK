using System.Runtime.InteropServices;
using Audio;
using Femur;
using UnityEngine;
using UnityEngine.Networking;

[NetworkSettings(channel = 1, sendInterval = 0f)]
public class CraneController : NetworkBehaviour, IControlHandeler_DriveTarget
{
	public enum State
	{
		idle = 0,
		movingToActive = 1,
		active = 2,
		movingToIdle = 3
	}

	[SyncVar]
	public float dampedArmSyncPosition;

	[SyncVar]
	private float distanceFromCenter;

	public bool hasUser;

	public bool seatActive;

	public Rigidbody machineDeck;

	public Rigidbody craneBase;

	public Rigidbody craneArm;

	public Rigidbody[] craneCableParts;

	public Rigidbody seat;

	public Rigidbody leftStick;

	public Rigidbody rightStick;

	public Transform seatProxy;

	public Transform craneTarget;

	public float seatTranslateDamping;

	public float seatRotateDamping;

	public float machineDeckDamping;

	public float armMovementDamping;

	public Transform seatNode_idle;

	public Transform seatNode_moving;

	public Transform seatNode_active;

	public Transform[] actorProxyParts;

	public float fakeSwingForce;

	public float resetDelay;

	public CMVcamTargeter cameraTargeterRef;

	public GeneralAudioData translateAudioData;

	public GeneralAudioData rotateAudioData;

	[Header("Engine Smoke")]
	public ParticleSystem[] EngineSmokeStacks;

	public float MinSmokeRate;

	public float MaxSMokeRate;

	public int startBurstcount;

	public float IdleParticleSpeed;

	public float ActiveParticleSpeed;

	public Color IdleColour;

	public Color ActiveColour;

	private bool startBurst;

	private AudioController.PooledAudioSource translateAudioSource;

	private AudioController.PooledAudioSource rotateAudioSource;

	private Animator animator;

	private const string CRANE_ARM_MOVE_ANIM = "CraneArmMove";

	[Header("Physics Sync")]
	public Transform MainJib;

	public Rigidbody MainJibRB;

	public Transform Linkage;

	public Rigidbody LinkageRB;

	public Transform CounterWeight;

	public Rigidbody CounterWeightRB;

	public Transform TieBack;

	public Rigidbody TieBackRB;

	public Transform HeadJib;

	public Rigidbody HeadJibRB;

	public Transform pistonStart;

	public Rigidbody pistonStartRB;

	public Transform pistonMiddle;

	public Rigidbody pistonMiddleRB;

	public Transform pistonEnd;

	public Rigidbody pistonEndRB;

	public State state;

	public bool moveBackground;

	public Transform cameraOffsetRoot;

	public Transform[] cameraOffsetNodes;

	private Actor actor;

	private ConfigurableJoint hipJoint;

	private ConfigurableJoint leftHandJoint;

	private ConfigurableJoint rightHandJoint;

	private Vector3 lastVelocity;

	private Vector3 craneCenter;

	private Vector3 targetPosition;

	private Vector3 targetDirection;

	private Quaternion targetRotation;

	private static float CRANE_ARM_MAX;

	private static float CRANE_ARM_MIN;

	private static float MAX_DIST;

	private static float ARM_SPEED;

	private static float ROTATION_SPEED;

	private Vector3 rotationAngle;

	public float NetworkdampedArmSyncPosition
	{
		get
		{
			return 0f;
		}
		[param: In]
		set
		{
		}
	}

	public float NetworkdistanceFromCenter
	{
		get
		{
			return 0f;
		}
		[param: In]
		set
		{
		}
	}

	private void Start()
	{
	}

	public void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void UpdateSeatPosition()
	{
	}

	private void UpdateArmPosition()
	{
	}

	private void UpdateTargetRotation()
	{
	}

	public void MoveActorPart(Transform actorPart, Transform actorProxyPart)
	{
	}

	public void AttachToSeat(Collider other)
	{
	}

	public void RemoveFromSeat()
	{
	}

	private void ResetSeat()
	{
	}

	private void MakeWeak()
	{
	}

	private void SetEngineSmokeSpeed()
	{
	}

	private void SetEngineSmokeRate(bool StartBurst = false)
	{
	}

	private void SetEngineSmokeColour(Color newCol)
	{
	}

	public void ReleaseDriveTarget()
	{
	}

	private void UNetVersion()
	{
	}

	public override int GetNetworkChannel()
	{
		return 0;
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
