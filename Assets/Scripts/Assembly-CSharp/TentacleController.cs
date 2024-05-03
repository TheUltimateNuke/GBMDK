using System.Collections.Generic;
using UnityEngine;

public class TentacleController : MonoBehaviour
{
	public enum State
	{
		Idle = 0,
		AttackingTarget = 1,
		AttackingEnviroment = 2,
		Retreting = 3,
		Flailing = 4
	}

	public TentacleSegment[] segments;

	[Header("Physics Settings")]
	public float idleForce;

	public float attackForce;

	public float retreteForce;

	public float upForce;

	public float maxVelocity;

	public float maxAngularVelocity;

	public Collider splashAudioCollider;

	public LayerMask targetingLayerMask;

	[Header("Targeting Settings")]
	public Transform searchArea;

	public float searchRadius;

	public Rigidbody targetedTarget;

	public Vector3 enviromentTarget;

	[Header("Position Settings")]
	public Vector3 disabledPosition;

	public Vector3 idlePosition;

	public Vector3 attackPosition;

	public Vector3 retretePosition;

	[Header("Grab Settings")]
	public LayerMask layerMask;

	public float gripStrength;

	public float releaseHeight;

	[HideInInspector]
	public bool hasObject;

	public GeneralAudioData grabAudioData;

	[Header("Aggression Settings")]
	public float idleTime;

	public float attackTime;

	[Range(0f, 100f)]
	public float targetedAttackChance;

	[Header("Status")]
	public State state;

	public State lastState;

	public float stateTimer;

	private Collider[] _hitColliders;

	private int _collidersFound;

	private List<Rigidbody> targets;

	private Vector3 oldEnviromentTarget;

	private Vector3 newEnviromentTarget;

	private RaycastHit[] targetingHit;

	private int tentacleLayer;

	private int ignoreAllLayer;

	private Vector3 searchAreaPosition;

	private Vector3 searchAreaForward;

	private bool gameStarted;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void GameStarted()
	{
	}

	private void Update()
	{
	}

	private void UpdateTentacle()
	{
	}

	private void FindTargets()
	{
	}

	public void UpdateSegmentsFixed()
	{
	}
}
