using System.Collections.Generic;
using Femur;
using GB.FSM.Bird;
using UnityEngine;

namespace GB.Game.Critters
{
	public class BirdActor : MonoBehaviour
	{
		public enum CollisionType
		{
			Enter = 0,
			Stay = 1,
			Exit = 2
		}

		public enum TweetType
		{
			Idle = 0,
			Angry = 1
		}

		public static float ROUTE_RECALC_TIME;

		public static float STOP_CARRY_TIME;

		[Header("Status")]
		public float health;

		public float maxHealth;

		public float maxUnconsciousTime;

		public bool birdActive;

		[Header("Routes")]
		public float IdleRouteCheckDelay;

		public float WanderRouteCheckDelay;

		public float AttackRouteCheckDelay;

		public float CarryRouteCheckDelay;

		[Header("State Times")]
		public float IdleTime;

		public float WanderTime;

		public float MinWanderTime;

		public float MaxWanderTime;

		public float MaxPerchTime;

		public float MinPerchTime;

		public float MaxPerchActionTime;

		public float MinPerchActionTime;

		[Header("Physics")]
		public float movementForce;

		public float actorAttackForce;

		public float envAttackForce;

		public float ActorCarryForce;

		public float SceneCarryForce;

		public float maxVelocity;

		public float maxEnvAttackVelocity;

		public float maxActorAttackVelocity;

		public float upForce;

		public float environmentDropHeight;

		public float environmentDropRadius;

		public float distanceForceIncreaseThreshold;

		public float ThrowStrength;

		public float maxAttackVelocity;

		[Header("Targeting")]
		public float fleeDistance;

		public float reviveSearchDistance;

		public float directFlightDistance;

		[Header("Anger Modifiers")]
		public float UnconciousAnger;

		public float FleeAnger;

		public List<MovementNode> activeMovementNodes;

		public MovementNode dropNode;

		public MovementNode idleNode;

		public int nodesIndex;

		[Header("Audio")]
		public GeneralAudioData idleTweetAudioData;

		public GeneralAudioData angryTweetAudioData;

		public GeneralAudioData knockoutAudioData;

		public GeneralAudioData birdFlappingAudioData;

		public float minTimeBetweenIdleTweets;

		public float maxTimeBetweenIdleTweets;

		public float minTimeBetweenAngryTweets;

		public float maxTimeBetweenAngryTweets;

		[SerializeField]
		private ConfigurableJoint joint;

		[SerializeField]
		public Rigidbody body;

		[SerializeField]
		public Rigidbody leftWing;

		[SerializeField]
		public Rigidbody rightWing;

		[SerializeField]
		public Rigidbody tail;

		[SerializeField]
		public Rigidbody beak;

		private float flapTimer;

		private bool flap;

		public Rigidbody targetPart;

		public GameObject critterTarget;

		public Actor targetActor;

		public GameObject GrabbedItem;

		private bool setup;

		private SkinnedMeshRenderer skinnedMeshRenderer;

		private float blinkTimer;

		private float mouthTimer;

		private int tweets;

		private float timeBetweenTweets;

		private float triggerDelay;

		private float flapDelay;

		private float distanceToTarget;

		public float distanceSinceLastUpdate;

		public float currentAttackForce;

		public Vector3 positionatLastUpdate;

		private float LocalAnger;

		public float TimeSinceLastNode;

		public float CheckForAgressionTimer;

		private InteractableObject interactableObject;

		private BirdFSM birdMachine;

		private BirdNetworker birdNetworker;

		public CritterEscalationManager _BirdManager;

		private TweetType currentTweetType;

		private bool waitingToThrow;

		private Rigidbody throwRB;

		public void OnValidate()
		{
		}

		public void Start()
		{
		}

		public void OnDestroy()
		{
		}

		private void BirdMachine_onStateChange(int stateID)
		{
		}

		public void SetupStartDelay(float StartDelay = 0f)
		{
		}

		private void StartBird()
		{
		}

		public void UpdateNetworkState(int newState)
		{
		}

		public void SetClientState(BirdFSM.BirdStateID state)
		{
		}

		public void SetBirdActive(bool activeState)
		{
		}

		private void FixedUpdate()
		{
		}

		public void CheckToGoAggressive()
		{
		}

		public void BlinkCheck()
		{
		}

		private void BlinkClose()
		{
		}

		private void BlinkOpen()
		{
		}

		public void SetTarget(InteractableObjectData newTarget)
		{
		}

		public void SetTarget(Actor newTarget)
		{
		}

		public void StopAttackingTarget()
		{
		}

		public void RouteCheck(CritterEscalationManager.RouteType routeType)
		{
		}

		private void NewIdleSpotRouteCheck(MovementNode lastIdleNode, int currentChecks, int maxChecks)
		{
		}

		public void ResetTweetTime()
		{
		}

		public void Tweet(TweetType tweetType, bool skipWait = false)
		{
		}

		public void MoveTowardPosition(Vector3 targetPos, float movementForce)
		{
		}

		public void JointBroken()
		{
		}

		public void ResetJoint()
		{
		}

		public void BreakJoint()
		{
		}

		public void ThrowObject()
		{
		}

		public void ChangePartGravity(bool useGravity)
		{
		}

		public void CheckHealth()
		{
		}

		private void RegenHealth()
		{
		}

		public void SetHealth(float newHealth)
		{
		}

		public void SetDamageModifier(InteractableObject.Damage damageModifier)
		{
		}

		public void FlapWings()
		{
		}

		public bool FindTargetEnvironment()
		{
			return false;
		}

		public bool FindTargetActor()
		{
			return false;
		}

		public bool FindDropTarget()
		{
			return false;
		}

		public void SetupGrab(Collision collision)
		{
		}

		public void CheckAndSetupGrab(Collision collision)
		{
		}

		public BirdFSM.BirdStateID GetCurrentState()
		{
			return default(BirdFSM.BirdStateID);
		}

		public void CheckDamage(Collision collision)
		{
		}

		private void CheckDamage_impl(Collision collision)
		{
		}

		public bool ShouldFlyAway()
		{
			return false;
		}

		public void PeckAction()
		{
		}

		public void HopAction()
		{
		}

		public void LeftWingAddTorque(float torque)
		{
		}

		public void RightWingAddTorque(float torque)
		{
		}

		public void AlignBodyToUpVector(Vector3 alignmentVector, Vector3 targetVector, float stability, float speed)
		{
		}

		public void AlignBodyForwardVector(Vector3 targetVector, float stability, float speed)
		{
		}

		public void AlignBodyUpVector(Vector3 targetVector, float stability, float speed)
		{
		}

		public void AlignToVector(Rigidbody part, Vector3 alignmentVector, Vector3 targetVector, float stability, float speed)
		{
		}
	}
}
