using Audio;
using UnityEngine;

public class SceneAudioClip : MonoBehaviour
{
	public AudioClip clip;

	public bool loop;

	public bool play2D;

	public bool playOnAwake;

	public float volume;

	public float pitch;

	public float minDistance;

	public float maxDistance;

	[Range(0f, 1f)]
	public float dopplerLevel;

	public VolumeLevels.SoundType soundType;

	public AudioMixerController.MixerGroup mixerGroup;

	private bool wasPaused;

	private AudioController.PooledAudioSource pooledSource;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}
}
