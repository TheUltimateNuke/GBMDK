using UnityEngine;

public class Trawler_Crain : MonoBehaviour
{
	public enum ArmAngle
	{
		low = 0,
		medium = 1,
		high = 2,
		none = 3
	}

	public Trawler_Mechanics trawlerMechanics;

	public ArmAngle angle;

	private Vector3 upperCableOffset;

	private Vector3 lowerCableOffset;

	public GameObject upperCable;

	public GameObject lowerCable;

	public Transform cableTarget;

	public ConfigurableJoint crainArmJoint;

	public Rigidbody crainAxle;

	public Rigidbody crainArm;

	public Rigidbody crainHook;

	public Rigidbody crainTip;

	public float armAlignmentForce;

	private ArmAngle lastAngle;

	private bool hasSunk;

	private bool hasLostObject;

	private ConfigurableJoint hookedObjectJoint;

	private Collider[] _hitColliders;

	private int _collidersFound;

	public bool _hasObject;

	public Transform leftJoystick;

	public Transform leftJoystickOrigin;

	public Transform rightJoystick;

	public Transform rightJoystickOrigin;

	public float leftJoystickAngle;

	public float rightJoystickAngle;

	public float armAngle;

	public float horizontalMoveSpeed;

	public float verticalMoveSpeed;

	public float joystickTriggerAngle;

	public GeneralAudioData movementAudioData;

	private bool movedLastFrame;

	private float triggerDelay;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void DelayedWeaken()
	{
	}

	private void UpdateJoystick()
	{
	}

	private void UpdateCables()
	{
	}
}
