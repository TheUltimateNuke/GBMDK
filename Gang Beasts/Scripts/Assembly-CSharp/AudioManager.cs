using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
	public AudioMixer master;

	public AudioMixerSnapshot[] snapshot;

	public AudioMixerSnapshot ambianceOnly;

	public AudioConfiguration deathSoundSource;

	public AudioSource bellSoundSource;

	public AudioSource warpSoundSource;

	public AudioClip[] deathSound;

	public AudioClip[] bellSound;

	public AudioClip[] warpSound;

	private int lastTotalDead;

	public GameModeHandeler gameModeHandeler;

	public GlobalManager GlobalManager;

	public int lives;

	private int lastRandom;

	private int randomClip;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void PlayDeathSound()
	{
	}

	private void ChangeTrack()
	{
	}

	private void PlayAmbiance()
	{
	}

	private void TrackCheck()
	{
	}
}
