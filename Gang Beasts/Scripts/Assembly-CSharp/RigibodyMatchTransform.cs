using UnityEngine;

public class RigibodyMatchTransform : MonoBehaviour, IRigCombine
{
	public Rigidbody ThisRigidbody;

	public Rigidbody TargetRigidbody;

	private string TargetName;

	private void FixedUpdate()
	{
	}

	public void PreCombineAction()
	{
	}

	public void PostCombineAction(Transform rootTransform)
	{
	}

	private Transform FindTransformViaName(Transform trans, string transformName)
	{
		return null;
	}
}
