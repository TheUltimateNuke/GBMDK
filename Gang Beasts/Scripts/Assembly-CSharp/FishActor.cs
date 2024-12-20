using System.Collections.Generic;
using Femur;
using UnityEngine;

public class FishActor : MonoBehaviour
{
	public enum State
	{
		Idle = 0,
		LookingForTarget = 1,
		Attacking = 2,
		Unconscious = 3
	}

	public enum CollisionType
	{
		Enter = 0,
		Stay = 1,
		Exit = 2
	}

	[Header("Status")]
	public float health;

	public float maxHealth;

	public float maxUnconsciousTime;

	public State state;

	[Header("Physics")]
	public float waterLevel;

	public float force;

	public Vector3 exitPosition;

	public float maxVelocity;

	public float upForce;

	[Header("Targeting")]
	public static List<Actor> actorsInSphere;

	public static List<FishActor> fishsInSphere;

	public LayerMask targetingLayerMask;

	public float searchDistance;

	private ConfigurableJoint joint;

	private Rigidbody body;

	private Rigidbody leftFin;

	private Rigidbody rightFin;

	private Rigidbody tailFin;

	private Rigidbody upperFin;

	private float idleTimer;

	private float unconsciousTimer;

	private float flapTimer;

	private bool flap;

	private Collider[] _hitColliders;

	private int _collidersFound;

	private Rigidbody target;

	private bool setup;

	private SkinnedMeshRenderer skinnedMeshRenderer;

	private float blink;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnJointBreak()
	{
	}

	private void BreakJoint()
	{
	}

	private void ChangePartGravity(bool useGravity)
	{
	}

	private void CheckHealth()
	{
	}

	public void OnCollision(Collision collision, CollisionType type)
	{
	}

	private void FlapWings()
	{
	}

	private void FindTarget()
	{
	}

	private void CheckDamage(Collision collision)
	{
	}

	public void AlignToVector(Rigidbody part, Vector3 alignmentVector, Vector3 targetVector, float stability, float speed)
	{
	}
}
