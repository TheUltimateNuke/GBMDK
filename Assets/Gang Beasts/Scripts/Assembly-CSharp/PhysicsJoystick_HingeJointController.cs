using UnityEngine;

public class PhysicsJoystick_HingeJointController : MonoBehaviour
{
	public Transform joystick;

	[Space]
	public Transform positiveTarget;

	public Transform negativeTarget;

	public float triggerDistance;

	[Space]
	public HingeJoint joint;

	[Space]
	public float minValue;

	public float maxValue;

	public float change;

	[Space]
	public float speed;

	private void Update()
	{
	}
}
