using System.Runtime.CompilerServices;
using DG.Tweening;
using GB.Networking.Objects;
using UnityEngine;
using UnityEngine.Networking;

public class FlagCapturePoint : NetworkBehaviour
{
	public delegate void FlagCaptureHandler(FlagCapturePoint flagCP);

	private Material targetMaterial;

	private Sequence flashSequence;

	private NetBeast _owner;

	private static int kRpcRpcFlashColor;

	public NetBeast Owner
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static event FlagCaptureHandler OnFlagCapture
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	public void Awake()
	{
	}

	public void OnTriggerEnter(Collider col)
	{
	}

	[ClientRpc]
	private void RpcFlashColor()
	{
	}

	private void FlashColor()
	{
	}

	private void UNetVersion()
	{
	}

	protected static void InvokeRpcRpcFlashColor(NetworkBehaviour obj, NetworkReader reader)
	{
	}

	public void CallRpcFlashColor()
	{
	}

	static FlagCapturePoint()
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
