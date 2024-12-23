using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking;

[NetworkSettings(channel = 1, sendInterval = 0f)]
public class GerstnerLiquid : Liquid
{
	private static readonly int WaveDistID;

	private static readonly int WaveSteepnessID;

	private static readonly int WaveCountID;

	private static readonly int WaveDirectionID;

	public Material material;

	private bool initalised;

	public float _WaveHeight;

	public float _WaveDistance;

	public float _WaveSteepness;

	public int _WaveCount;

	public Vector4 _WaveDirection;

	public float offset;

	public float multiplier;

	[SyncVar(hook = "OnCustomTimeChange")]
	private float customTime;

	public static readonly int MAX_WAVE_COUNT;

	public float CustomTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float NetworkcustomTime
	{
		get
		{
			return 0f;
		}
		[param: In]
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnCustomTimeChange(float newTime)
	{
	}

	private void OnDestroy()
	{
	}

	private void SetMaterialParams()
	{
	}

	public override float GetSurfaceHeight(SimpleBuoyancy buoyancy)
	{
		return 0f;
	}

	private new void Update()
	{
	}

	private void UNetVersion()
	{
	}

	public override int GetNetworkChannel()
	{
		return 0;
	}

	public override float GetNetworkSendInterval()
	{
		return 0f;
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
