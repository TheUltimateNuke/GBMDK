using UnityEngine;

public class Truck1 : MonoBehaviour
{
	private Transform thisTransform;

	private Rigidbody thisRigidbody;

	public float force;

	public Vector3 min;

	public Vector3 max;

	public bool outOfBounds;

	public int seed;

	private Vector3 startPos;

	private Vector3 direction;

	public Rigidbody[] AttachedWheels;

	public float BumpFakeMinTime;

	public float BumpFakeMaxTime;

	public float BumpFakeForceMin;

	public float BumpFakeForceMax;

	private float nextBumpFakeTime;

	private float currentBumpFakeTime;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void HandleFakeBump()
	{
	}

	public void NewDirection()
	{
	}

	public void AlignToVector(Rigidbody part, Vector3 alignmentVector, Vector3 targetVector, float stability, float speed)
	{
	}
}
