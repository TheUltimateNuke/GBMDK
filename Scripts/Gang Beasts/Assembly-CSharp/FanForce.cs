using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class FanForce : MonoBehaviour
{
	public enum FanState
	{
		Stoped = 0,
		Accelerating = 1,
		Decelerating = 2
	}

	public enum ForceType
	{
		Push = 0,
		Pull = 1
	}

	public List<Rigidbody> targetsInSphere;

	public Collider thisCollider;

	public Rigidbody fanRigidbody;

	public HingeJoint fanJoint;

	public HingeJoint[] bladeJoint;

	public Rigidbody[] bladeRigidbody;

	[FormerlySerializedAs("light")]
	public Light fanLight;

	public FanState fanState;

	private FanState lastFanState;

	public ForceType forceType;

	private ForceType lastForceType;

	public float restartDelay;

	private float restartTimer;

	public float activeTime;

	private float activeTimer;

	public float fanSpeed;

	public float applyedTorque;

	public double power;

	public float powerReduction;

	public AudioSource[] audioSource;

	public WindZone windZone;

	public AudioSource turnA;

	public AudioSource turnB;

	public AudioSource fanOn;

	public AudioSource fanOff;

	public AudioSource fanLoop;

	public float fanLoopVolume;

	public float fanLoopVolumeStartStep;

	public float fanLoopVolumeEndStep;

	public float fanLoopPitchMod;

	private float fanLoopCurrentVolume;

	public float maxVolume;

	private float ExponentialVolicty(float origVolicty)
	{
		return 0f;
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void ChangeDirection()
	{
	}

	private void TurnA()
	{
	}

	private void TurnB()
	{
	}

	private void FixedUpdate()
	{
	}

	private void ApplyForces()
	{
	}

	private void PulseLight()
	{
	}

	private void DisableLight()
	{
	}

	private void OnTriggerEnter(Collider collider)
	{
	}

	private void OnTriggerExit(Collider collider)
	{
	}
}
