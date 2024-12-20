using CoreNet.Pooling;
using UnityEngine;
using UnityEngine.Networking;

public class IncineratorBox : PooledSyncItem
{
	private Rigidbody _CachedRigidbody;

	private void Start()
	{
	}

	public override void OnSpawn()
	{
	}

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
