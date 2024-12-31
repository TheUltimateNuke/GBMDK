using CoreNet.Pooling;
using UnityEngine;
using UnityEngine.Networking;

public class Train : PooledSyncItem
{
	private bool _wasPooled;

	private Rigidbody _CachedRigidbody;

	public Vector3 moveAmount;

	private AudioSource trainLoop;

	private void Awake()
	{
	}

	public override void OnSpawn()
	{
	}

	public void Update()
	{
	}

	[ServerCallback]
	public void FixedUpdate()
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
