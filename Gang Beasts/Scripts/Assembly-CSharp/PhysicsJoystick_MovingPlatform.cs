using UnityEngine;

public class PhysicsJoystick_MovingPlatform : MonoBehaviour
{
	public Transform joystick;

	[Space]
	public Transform positiveTarget;

	public Transform negativeTarget;

	public float triggerDistance;

	[Space]
	public Vector3 direction;

	[Space]
	public float minValue;

	public float maxValue;

	public float change;

	[Space]
	public float speed;

	private Rigidbody platform;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
