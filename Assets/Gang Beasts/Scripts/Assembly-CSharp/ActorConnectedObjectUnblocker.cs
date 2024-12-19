using Femur;
using UnityEngine;

public class ActorConnectedObjectUnblocker : MonoBehaviour
{
	private Actor _actorRef;

	private Joint joinedBody;

	private Collider myCollider;

	private LayerMask testMask;

	private float checkTimer;

	private float testRadius;

	private bool checkingForForeignObject;

	public void Start()
	{
	}

	public void SetActorRef(Actor myActor)
	{
	}

	private void TestForForeignSeperator()
	{
	}

	private void OnCollisionStay(Collision collision)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
