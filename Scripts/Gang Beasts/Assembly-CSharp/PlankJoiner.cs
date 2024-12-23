using UnityEngine;

public class PlankJoiner : MonoBehaviour
{
	public float breakForce;

	public float breakTorque;

	public Vector3 jointAxis;

	public ConfigurableJointMotion angularXLimit;

	public ConfigurableJointMotion angularYLimit;

	public ConfigurableJointMotion angularZLimit;

	private void Start()
	{
	}
}
