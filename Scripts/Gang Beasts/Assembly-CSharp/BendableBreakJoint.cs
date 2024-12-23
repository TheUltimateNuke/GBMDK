using CoreNet.StateSync.Triggers;
using GB.Networking.StateSync.Syncs;
using UnityEngine;

public class BendableBreakJoint : MonoBehaviour
{
	public Rigidbody targetRigidbody;

	public float minBreakForce;

	public float maxBreakForce;

	public float recreateDelay;

	private GameObject thisGameObject;

	private float breakForce;

	private BreakableJointSync _cachedSync;

	private BendableJointSyncTrigger _cachedTrigger;

	private FixedJoint _cachedjoint;

	private void Awake()
	{
	}

	private void OnJointBreak()
	{
	}

	private void RecreateJoint()
	{
	}
}
