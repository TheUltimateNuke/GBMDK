using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BeatSynchronizer : MonoBehaviour
{
	public delegate void AudioStartAction(double syncTime);

	public float bpm;

	public float startDelay;

	public bool playOnStart;

	private AudioSource audioSource;

	public List<AudioSource> extraAudioSources;

	public static event AudioStartAction OnAudioStart
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

	private void Start()
	{
	}

	public void StartAudio(double time)
	{
	}

	public void StopAudio()
	{
	}
}
