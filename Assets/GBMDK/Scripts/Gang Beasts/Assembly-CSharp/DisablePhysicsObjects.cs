using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DisablePhysicsObjects : NetworkBehaviour, ISerializationCallbackReceiver
{
	private Dictionary<GameObject, short> _idsByGameobject;

	private Dictionary<short, GameObject> _gameobjectsById;

	[SerializeField]
	private List<short> _serialisedIds;

	[SerializeField]
	private List<GameObject> _serialisedGameobjects;

	private static int kRpcRpcKillPhysicsObject;

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	[ClientRpc]
	private void RpcKillPhysicsObject(short id)
	{
	}

	[ContextMenu("Gather Ids")]
	private void GatherIds()
	{
	}

	private void UNetVersion()
	{
	}

	protected static void InvokeRpcRpcKillPhysicsObject(NetworkBehaviour obj, NetworkReader reader)
	{
	}

	public void CallRpcKillPhysicsObject(short id)
	{
	}

	static DisablePhysicsObjects()
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
