using System.Collections.Generic;
using CoreNet.Pooling;
using UnityEngine;
using UnityEngine.Networking;

public class MeatPaste : PooledSyncItem
{
	private struct MeatPasteCached
	{
		public Rigidbody rb;

		public PhysicAudioEmitter audioEmitter;

		public Vector3 rbStartPos;

		public GrabEvent grabEvents;
	}

	private MeatPasteCached[] cachedRigidbodies;

	private List<Joint> _joints;

	private void Awake()
	{
	}

	public override void OnSpawn()
	{
	}

	[ContextMenu("Repool Now")]
	public void RepoolNow()
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
