using Femur;
using UnityEngine;

public class Piggyback : MonoBehaviour
{
	public bool hasUser;

	public Rigidbody back;

	public Transform[] actorProxyParts;

	public float resetDelay;

	private Actor actor;

	private ConfigurableJoint hipJoint;

	public void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void MoveActorPart(Transform actorPart, Transform actorProxyPart)
	{
	}

	public void AttachToSeat(Collider other)
	{
	}

	public void RemoveFromSeat()
	{
	}

	private void ResetSeat()
	{
	}

	private void MakeWeak()
	{
	}

	private void OnJointBreak()
	{
	}

	private void OnTriggerEnter(Collider otherCollider)
	{
	}
}
