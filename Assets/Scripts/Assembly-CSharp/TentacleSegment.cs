using UnityEngine;

public class TentacleSegment : MonoBehaviour
{
	public enum State
	{
		Idle = 0,
		AttackingTarget = 1,
		AttackingEnviroment = 2,
		Retreting = 3,
		Flailing = 4
	}

	public Rigidbody thisRigidbody;

	public Collider thisCollider;

	[HideInInspector]
	public ConfigurableJoint joint;

	[HideInInspector]
	public bool hasGrip;

	[HideInInspector]
	public float stateTimer;

	public TentacleController controller;

	public bool rootSegment;

	public bool showDebugLines;

	private Vector3 direction;

	private Vector3 newDirection;

	private float wiggleTimer;

	public State state;

	private State lastState;

	private Vector3 boundsOffset;

	private float currentForce;

	private float currentVelocity;

	private float smoothTime;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void FixedUpdateImpl()
	{
	}

	private void RootSegmentUpdate(Vector3 rigidbodyPosition)
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

	private void OnJointBreak()
	{
	}
}
