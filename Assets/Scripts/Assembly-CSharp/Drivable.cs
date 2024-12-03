using Femur;
using UnityEngine;

public class Drivable : MonoBehaviour
{
	public bool hasUser;

	public Transform hipsAttachmentPoint;

	public Transform leftHandAttachmentPoint;

	public Transform rightHandAttachmentPoint;

	public Rigidbody vehicle;

	public Rigidbody leftAxle;

	public Rigidbody rightAxle;

	public Rigidbody stearingWheel;

	public Rigidbody[] wheels;

	public Transform camera;

	private Actor actor;

	private ConfigurableJoint hipJoint;

	private ConfigurableJoint leftHandJoint;

	private ConfigurableJoint rightHandJoint;

	private Vector3 lastVelocity;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnJointBreak(float breakForce)
	{
	}

	private void ResetCar()
	{
	}

	private void MakeWeak()
	{
	}

	private void Launch()
	{
	}
}
