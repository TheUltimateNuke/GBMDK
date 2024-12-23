using UnityEngine;

public class JoinedRigidbodysStabilizer : MonoBehaviour
{
	public Rigidbody supportRoot;

	public JoinedRigidbodysStabilizer[] otherStabilizers;

	public bool broken;

	private ConfigurableJoint supportJoint;

	private Rigidbody thisRigidbody;

	private void Start()
	{
	}

	private void CheckJoints()
	{
	}

	private void OnJointBreak()
	{
	}

	public void JointDestroyed()
	{
	}
}
