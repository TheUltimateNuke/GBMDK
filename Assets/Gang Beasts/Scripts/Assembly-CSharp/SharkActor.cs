using System.Collections.Generic;
using Femur;
using UnityEngine;

public class SharkActor : MonoBehaviour
{
	public enum State
	{
		Sleeping = 0,
		Searching = 1,
		Attacking = 2,
		Breaching = 3,
		Carrying = 4,
		Retreating = 5,
		Diving = 6
	}

	public enum BreachState
	{
		Inactive = 0,
		Travelling = 1,
		Diving = 2,
		Breaching = 3,
		Attacking = 4
	}

	public enum CollisionType
	{
		Enter = 0,
		Stay = 1,
		Exit = 2
	}

	[HideInInspector]
	public static int frameCountStart;

	[HideInInspector]
	public static readonly int OVERLAP_TEST_FRAME_DELAY;

	[Header("Status")]
	public int startDelay;

	public float health;

	public float maxHealth;

	public float maxUnconsciousTime;

	public bool inWater;

	public Rigidbody rigidbodyInMouth;

	public FixedJoint biteJoint;

	public GeneralAudioData openMouthAudioData;

	public GeneralAudioData closeMouthAudioData;

	public State nextState;

	public State currentState;

	public State lastState;

	public BreachState breachState;

	[Space]
	public float stateTimer;

	[Space]
	public float minSleepingTime;

	public float maxSleepingTime;

	public float sleepTime;

	[Space]
	public float minSearchingTime;

	public float maxSearchingTime;

	public float searchTime;

	[Space]
	public float minAttackingTime;

	public float maxAttackingTime;

	public float attackTime;

	[Header("Physics")]
	public float onLandMovementSpeed;

	public float onLandHopStrength;

	[Space]
	public float inWaterMovementSpeed;

	public float inWaterLeapStrength;

	public float inWaterDiveStrength;

	[Space]
	public float maxVelocity;

	public float upForce;

	[Space]
	public SimpleBuoyancy torsoBuoyancy;

	public SimpleBuoyancy[] sharksBuoyancy;

	public float surfaceSpeed;

	public Rigidbody[] sharksRigidbodys;

	[Header("Targeting")]
	public static List<Actor> actorsInSphere;

	public LayerMask targetingLayerMask;

	public float searchDistance;

	public Transform[] searchNodes;

	public Transform[] retreatNodes;

	public Transform[] diveNodes;

	public Transform[] breachNodes;

	public float breachDepth;

	public float breachHeight;

	private ConfigurableJoint joint;

	[Header("Parts")]
	public Rigidbody torso;

	public Rigidbody head;

	public Rigidbody jaw;

	public Rigidbody neck;

	public Rigidbody leftPectoralFin;

	public Rigidbody rightPectoralFin;

	public Rigidbody tailStart;

	public Rigidbody tailMid;

	public Rigidbody tailEnd;

	private float idleTimer;

	private float unconsciousTimer;

	private float moveTimer;

	private float breachTimer;

	private int step;

	private int currentSearchNode;

	private bool searchDirection;

	private Vector3 nodeVelocity;

	private Collider[] _hitColliders;

	private int _collidersFound;

	private Rigidbody target;

	private Vector3 destination;

	private Vector3 currentNodeDirection;

	private Vector3 lastNodeDirrection;

	private bool useBuoyancy;

	private bool run;

	private bool mouthOpen;

	private int frameCount;

	private void Start()
	{
	}

	private void FindTargetTicker()
	{
	}

	private void FixedUpdate()
	{
	}

	private void CheckHealth()
	{
	}

	private void Sleeping()
	{
	}

	private void Searching()
	{
	}

	private void Attacking()
	{
	}

	private void Breaching()
	{
	}

	private void Carrying()
	{
	}

	private void Retreating()
	{
	}

	private void Diving()
	{
	}

	private void MoveOnLand(Vector3 targetDirection)
	{
	}

	private void MoveInWater(Vector3 targetDirection)
	{
	}

	private void LookAtTarget(Vector3 targetDirection)
	{
	}

	private void OpenMouth(Vector3 targetDirection)
	{
	}

	private void CloseMouth(Vector3 targetDirection)
	{
	}

	private int FindClosestNode(Transform[] nodes)
	{
		return 0;
	}

	private void FindTarget()
	{
	}

	private void CheckDamage(Collision collision)
	{
	}

	private void SetBuoyancy(bool active)
	{
	}

	private void Buoyancy()
	{
	}

	public void AlignToVector(Rigidbody part, Vector3 alignmentVector, Vector3 targetVector, float force)
	{
	}

	public void DelayedStart()
	{
	}
}
