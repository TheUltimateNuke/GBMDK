using UnityEngine;

public class TentacleSegment : MonoBehaviour
{
	public Rigidbody thisRigidbody;

	public Collider thisCollider;

	[HideInInspector]
	public ConfigurableJoint joint;

	public bool hasGrip;

	public float stateTimer;

	public TentacleController controller;

	public bool rootSegment;

	public bool tipSegment;

	public bool showDebugLines;

	private Vector3 direction;

	private Vector3 newDirection;

	private float wiggleTimer;

	private Vector3 rootTargetPos;

	private float moveSpeedModifier;

	private TentacleControllerState state;

	private TentacleControllerState lastState;

	public float upForce;

	private Vector3 boundsOffset;

	private float currentForce;

	private float currentVelocity;

	private float smoothTime;

	private int tentacleLayer;

	private int railingLayer;

	private int actorLayer;

	private Rigidbody grabbedRigidBody;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnStateChanged(TentacleControllerState newState)
	{
	}

	public void FixedUpdateImpl(Vector3 rootMovement)
	{
	}

	public Vector3 GetRootSegmentMovement()
	{
		return default(Vector3);
	}

	public float RootToTarget()
	{
		return 0f;
	}

	public void Shrug(Vector3 shrugDirection)
	{
	}

	private void SegmentUpdate(Vector3 rigidbodyPosition)
	{
	}

	private void Idle(Vector3 rigidBodyPosition)
	{
	}

	private void AttackTarget()
	{
	}

	private void AttackEnviroment()
	{
	}

	private void Flail()
	{
	}

	private void Retreat()
	{
	}

	public void ReleaseGrip()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnJointBreak()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
