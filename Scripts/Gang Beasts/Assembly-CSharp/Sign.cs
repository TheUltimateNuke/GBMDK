using CoreNet.Pooling;
using UnityEngine;
using UnityEngine.Networking;

public class Sign : PooledSyncItem
{
	public Vector3 StartPos;

	public Vector3 EndPos;

	public float Speed;

	public GameObject[] Boards;

	private Rigidbody _CachedRigidbody;

	private static int kRpcRpc_SetActiveBoards;

	private void Start()
	{
	}

	private void OnLevelReset()
	{
	}

	public override void OnSpawn()
	{
	}

	[ServerCallback]
	private void FixedUpdate()
	{
	}

	[ServerCallback]
	private void RandomizeBoards()
	{
	}

	[Server]
	private void SetActiveBoards(int index)
	{
	}

	[ClientRpc]
	private void Rpc_SetActiveBoards(int index)
	{
	}

	private void UNetVersion()
	{
	}

	protected static void InvokeRpcRpc_SetActiveBoards(NetworkBehaviour obj, NetworkReader reader)
	{
	}

	public void CallRpc_SetActiveBoards(int index)
	{
	}

	static Sign()
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
