using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking;

[NetworkSettings(channel = 1, sendInterval = 1f)]
public class WheelAmbientAudio : NetworkBehaviour
{
	private float _lastUpdate;

	private float _currentWheelSpeed;

	[SyncVar]
	private float _targetWheelSpeed;

	[SerializeField]
	private AudioClip _wheelAxelAmbientAudioClip;

	[SerializeField]
	private float _wheelAxelAmbientAudioMaxPitchMaxSpeed;

	[SerializeField]
	private AnimationCurve _wheelPitchCurve;

	[SerializeField]
	private ParticleSystem[] _particles;

	[SerializeField]
	private WheelRotator _wheelRotator;

	private AudioSource _playingAudioSource;

	private static int kRpcRpcOnEsclation;

	public float WheelSpeed
	{
		get
		{
			return 0f;
		}
		private set
		{
		}
	}

	public float Network_targetWheelSpeed
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

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private float GetWheelSpeed()
	{
		return 0f;
	}

	private void OnEsclation()
	{
	}

	[ClientRpc]
	private void RpcOnEsclation()
	{
	}

	private void UNetVersion()
	{
	}

	protected static void InvokeRpcRpcOnEsclation(NetworkBehaviour obj, NetworkReader reader)
	{
	}

	public void CallRpcOnEsclation()
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

	static WheelAmbientAudio()
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
