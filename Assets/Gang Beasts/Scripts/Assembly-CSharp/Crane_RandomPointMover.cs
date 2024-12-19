using UnityEngine;

public class Crane_RandomPointMover : MonoBehaviour
{
	public enum HookState
	{
		idle = 0,
		rotateLeft = 1,
		rotateRight = 2
	}

	public enum BaseState
	{
		idle = 0,
		moveForwards = 1,
		moveBackwards = 2
	}

	public Crane crane;

	[Space]
	public float stateChangeDelayMin;

	public float stateChangeDelayMax;

	[Space]
	public Transform armMovementCenterPoint;

	public float armMovementRadius;

	[Space]
	public float maxDistanceBaseCanMove;

	public float baseMovementSpeed;

	public BaseState baseState;

	[Space]
	public float hookForceMin;

	public float hookForceMax;

	public HookState hookState;

	[Space]
	public bool keepCloseToOrigin;

	public float distanceToOrigin;

	public float timeAllowedAtDistance;

	private float distanceTimer;

	private RaycastHit[] sphereCastResults;

	private float hookRotationForce;

	private Vector3 startPosition;

	private Vector3 targetPosition;

	private float adjustedBaseMovementSpeed;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void GameStarted()
	{
	}

	private void FixedUpdate()
	{
	}

	private void BumpCheck()
	{
	}

	private void ChangeCraneBasePosition()
	{
	}

	private void ChangeHookState()
	{
	}

	private void ChangeCraneArmPosition()
	{
	}
}
