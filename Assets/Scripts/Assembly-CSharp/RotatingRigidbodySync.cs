using CoreNet.StateSync.Syncs;
using UnityEngine;

public class RotatingRigidbodySync : TransformSync
{
	protected bool _sync;

	private Rigidbody _rigidbody;

	[SerializeField]
	private bool _ignoreKinematicChanges;

	private bool testedForRB;

	private HingeJoint _hingeJoint;

	public bool Syncing => false;

	public override Vector3 CurrentPosition => default(Vector3);

	public override Quaternion CurrentRotation => default(Quaternion);

	public Rigidbody RigidbodyTest => null;

	public HingeJoint HingeJoint => null;

	protected override void SetPosition(Vector3 position, bool teleport = false)
	{
	}

	protected override void SetRotation(Quaternion rotation, bool teleport = false)
	{
	}

	public override void SetSyncing(bool syncing, bool isServer)
	{
	}

	private void ConfigureRotatingRigidbody(bool isKinematic)
	{
	}
}
