using UnityEngine;
using UnityEngine.Networking;

public class Flag : NetworkBehaviour
{
	[HideInInspector]
	public bool Captured;

	public void Capture()
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
