using System.Collections.Generic;
using Femur;
using UnityEngine;

public class RatActor : MonoBehaviour
{
	public enum State
	{
		Idle = 0,
		LookingForTarget = 1,
		Attacking = 2,
		Carrying = 3,
		Unconscious = 4
	}

	public enum CollisionType
	{
		Enter = 0,
		Stay = 1,
		Exit = 2
	}

	public enum SqueakType
	{
		Idle = 0,
		Angry = 1
	}

	[Header("Status")]
	public float health;

	public float maxHealth;

	public float maxUnconsciousTime;

	public State state;

	[Header("Physics")]
	public float attackForce;

	public float leapUpForce;

	public float leapForwardForce;

	public float carryForce;

	public Vector3 dropPosition;

	public float maxVelocity;

	public float upForce;

	[Header("Targeting")]
	public static List<Actor> actorsInSphere;

	public float searchDistance;

	[Header("Audio")]
	public GeneralAudioData idleSqueakAudioData;

	public GeneralAudioData angrySqueakAudioData;

	public GeneralAudioData knockoutAudioData;

	public GeneralAudioData ratScurryingAudioData;

	public float minTimeBetweenIdleTweets;

	public float maxTimeBetweenIdleTweets;

	public float minTimeBetweenAngryTweets;

	public float maxTimeBetweenAngryTweets;

	private ConfigurableJoint joint;

	private Rigidbody head;

	private Rigidbody body;

	private Rigidbody tailStart;

	private Rigidbody tailEnd;

	private float idleTimer;

	private float unconsciousTimer;

	private float runTimer;

	private bool step;

	public Rigidbody target;

	private bool setup;

	private SkinnedMeshRenderer skinnedMeshRenderer;

	private float blinkTimer;

	private float mouthTimer;

	private int tweets;

	private float timeBetweenTweets;

	private float triggerDelay;

	private float flapDelay;

	private bool onGround;

	private float leapTime;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void BlinkCheck()
	{
	}

	private void BlinkClose()
	{
	}

	private void BlinkOpen()
	{
	}

	private void Idle()
	{
	}

	private void LookForTarget()
	{
	}

	private void Attack()
	{
	}

	private void Carry()
	{
	}

	private void Unconscious()
	{
	}

	private void Squeak(SqueakType squeakType)
	{
	}

	private void OnJointBreak()
	{
	}

	private void BreakJoint()
	{
	}

	private void CheckHealth()
	{
	}

	public void OnCollisionEnter(Collision collision)
	{
	}

	public void CollisionCheck(Collision collision)
	{
	}

	private void Run()
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
