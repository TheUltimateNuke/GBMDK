using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Femur;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class TheHill : NetworkBehaviour
{
	public delegate void HillTickHandler(TheHill hill, Actor hillOwner);

	public Text countText;

	private Dictionary<Actor, int> playersInTheHill;

	private float tickTimer;

	private Actor currentOwner;

	private Material targetMaterial;

	[SyncVar]
	private Color targetColor;

	[SyncVar]
	private int hillCount;

	public Color NetworktargetColor
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

	public int NetworkhillCount
	{
		get
		{
			return 0;
		}
		[param: In]
		set
		{
		}
	}

	public static event HillTickHandler OnHillTick
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

	private void Awake()
	{
	}

	public void OnTriggerEnter(Collider col)
	{
	}

	public void OnTriggerExit(Collider col)
	{
	}

	private void UpdateOwner()
	{
	}

	public void UpdateCount(int newCount)
	{
	}

	private void Update()
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
