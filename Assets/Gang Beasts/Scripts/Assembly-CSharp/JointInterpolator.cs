using UnityEngine;
using UnityEngine.Networking;

public class JointInterpolator : MonoBehaviour
{
	public Transform ForwardTarget;

	public Transform UpTarget;

	public Transform Parent;

	public Vector3 RotationalOffset;

	private NetworkBehaviour _NetBehaviour;

	public void Start()
	{
	}

	public void Update()
	{
	}

	private void TryConfigureRigidbody()
	{
	}

	private void SetParent()
	{
	}

	private void UpdateInterpolation()
	{
	}

	private bool ShouldInterpolate()
	{
		return false;
	}
}
