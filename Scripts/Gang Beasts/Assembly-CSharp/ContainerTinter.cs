using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking;

public class ContainerTinter : NetworkBehaviour
{
	public Material materialA;

	public Material materialB;

	public Color[] colors;

	[SyncVar(hook = "SetColour")]
	public Color selectedColour;

	public int seedModifier;

	public Color NetworkselectedColour
	{
		get
		{
			return default(Color);
		}
		[param: In]
		set
		{
		}
	}

	private void Start()
	{
	}

	private void SetColour(Color newColour)
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
