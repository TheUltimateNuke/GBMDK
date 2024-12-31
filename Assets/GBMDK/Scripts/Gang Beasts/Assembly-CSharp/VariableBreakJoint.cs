using UnityEngine;

public class VariableBreakJoint : MonoBehaviour
{
	public float minBreakForce;

	public float maxBreakForce;

	[SerializeField]
	public Joint JointReference;

	private void Awake()
	{
	}

	private void SetupJoint()
	{
	}
}
