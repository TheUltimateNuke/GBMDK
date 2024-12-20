using CoreNet.Pooling;
using UnityEngine;
using UnityEngine.Networking;

public class BoulderTracker : PooledSyncItem
{
	public float despawnHeight;

	public float despawnDistance;

	public float scale;

	private Rigidbody thisRigidbody;

	private ConstantForce thisConstantForce;

	private static int kRpcRpc_SetBoulderSize;

	private void Awake()
	{
	}

	[ServerCallback]
	private void Update()
	{
	}

	[Server]
	public void SetBoulderSize(float scale)
	{
	}

	[ClientRpc]
	private void Rpc_SetBoulderSize(float scale, Vector3 localScale)
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

	protected static void InvokeRpcRpc_SetBoulderSize(NetworkBehaviour obj, NetworkReader reader)
	{
	}

	public void CallRpc_SetBoulderSize(float scale, Vector3 localScale)
	{
	}

	static BoulderTracker()
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
