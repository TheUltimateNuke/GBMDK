using UnityEngine;
using UnityEngine.Networking;

public class Truck : NetworkBehaviour
{
	private Transform thisTransform;

	private Rigidbody thisRigidbody;

	public float force;

	public Vector3 min;

	public Vector3 max;

	public bool outOfBounds;

	private Vector3 direction;

	private void Start()
	{
	}

	[ServerCallback]
	private void FixedUpdate()
	{
	}

	public void NewDirection()
	{
	}

	public void AlignToVector(Rigidbody part, Vector3 alignmentVector, Vector3 targetVector, float stability, float speed)
	{
	}

	private void UNetVersion()
	{
	}

	public override bool OnSerialize(NetworkWriter writer, bool forceAll)
	{
		return false;
	}

	public override void OnDeserialize(NetworkReader reader, bool initialState)
	{
	}

	public override void PreStartClient()
	{
	}
}
