using System.Runtime.InteropServices;
using Audio;
using UnityEngine;
using UnityEngine.Networking;

public class BurgerDwell : NetworkBehaviour
{
	[SerializeField]
	private float _dwellTimeUntilCollapseMin;

	[SerializeField]
	private float _dwellTimeUntilCollapseMax;

	[SerializeField]
	private Joint[] _joints;

	[SerializeField]
	private AudioClip[] _creakingAudioClips;

	[SerializeField]
	private float _percentageBerforeStartCreaking;

	[SerializeField]
	private AnimationCurve _creakingCurve;

	[SerializeField]
	private AudioClip _snapAudioClip;

	[SyncVar]
	private int m_beastsInside;

	[SyncVar]
	private bool _broken;

	[SyncVar]
	private float _percentage;

	private float _currentDwellTime;

	private float _maxDwellTime;

	private int _lastClipIndex;

	private AudioController.PooledAudioSource _creakingAudioSource;

	private const string _actorTag = "Actor";

	private int _beastsInside
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Networkm_beastsInside
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

	public bool Network_broken
	{
		get
		{
			return false;
		}
		[param: In]
		set
		{
		}
	}

	public float Network_percentage
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

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void Break()
	{
	}

	private AudioClip GetClip()
	{
		return null;
	}

	private void Update()
	{
	}

	private void OnCreakingFinished()
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
