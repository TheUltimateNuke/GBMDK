using UnityEngine;

public class Arrow : MonoBehaviour
{
	public float velocity;

	public float breakForce;

	private Transform thisTransform;

	private CapsuleCollider thisCollider;

	private Rigidbody thisRigidbody;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider collider)
	{
	}

	public void FixedUpdate()
	{
	}
}
