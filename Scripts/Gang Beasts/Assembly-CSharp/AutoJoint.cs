using UnityEngine;

public class AutoJoint : MonoBehaviour
{
	public float searchRadius;

	public Rigidbody parentRigidbody;

	public float breakForce;

	public float breakTorque;

	public Vector3 jointAxis;

	public ConfigurableJointMotion angularXLimit;

	public ConfigurableJointMotion angularYLimit;

	public ConfigurableJointMotion angularZLimit;

	public ConfigurableJoint joint;

	private void OnDrawGizmos()
	{
	}
}
