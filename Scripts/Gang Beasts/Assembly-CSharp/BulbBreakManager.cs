using UnityEngine;
using UnityEngine.Networking;

[SingularComponent]
public class BulbBreakManager : NetworkBehaviour
{
	private static BulbBreakManager _instance;

	[SerializeField]
	private BulbBreakerStopOnJointBreak[] bulbs;

	private static int kRpcRpcBreak;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	private void Awake()
	{
	}

	public static void Break(int id)
	{
	}

	[ClientRpc]
	private void RpcBreak(int id)
	{
	}

	[ContextMenu("Fetch All Bulb Breaks")]
	private void FetchAllBulbBreaks()
	{
	}

	private void UNetVersion()
	{
	}

	protected static void InvokeRpcRpcBreak(NetworkBehaviour obj, NetworkReader reader)
	{
	}

	public void CallRpcBreak(int id)
	{
	}

	static BulbBreakManager()
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
