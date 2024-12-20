using UnityEngine;

public class JointBreakEvent : MonoBehaviour
{
	public bool StartNoGravity;

	public Rigidbody Rigidbody;

	public float MassAfterBreak;

	public float DragAfterBreak;

	public float AngularDragAfterBreak;

	public GameObject[] ReparentGameObjects;

	private void Start()
	{
	}

	public void OnJointBreak(float breakForce)
	{
	}
}
