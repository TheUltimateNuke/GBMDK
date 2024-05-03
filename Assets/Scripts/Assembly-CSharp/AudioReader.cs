using System;
using GB.Utils;
using UnityEngine;

public class AudioReader : MonoBehaviour
{
	[Flags]
	public enum AudioSourceMask
	{
		ASide = 1,
		BSide = 2,
		Drums = 4
	}

	public enum AudioBlending
	{
		Additive = 0,
		Multiplicative = 1
	}

	public const int k_sampleCount = 512;

	public const int k_bandCount = 8;

	public static float[] samples;

	public static float[] freqBand;

	public static float[] bandBuffer;

	[EnumUtils.EnumFlags]
	public AudioBlending audioBlending;

	public bool accountForVolume;

	public bool _pushSelectedAudioSourceIntoCustom;

	public AudioSource _customAudioSource;

	private float[] bufferDecrease;

	private float[] tempSamples;

	private bool hasInitalSamples;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void GetSpectrumAudioSource()
	{
	}

	private void AccountForVolume(ref float[] sourceSamples, float volume)
	{
	}

	private void AddSamples(ref float[] sourceSamples, float[] addingSamples)
	{
	}

	private bool IsSourceEnabled(AudioSourceMask checkFor, AudioSourceMask checking)
	{
		return false;
	}

	private void MakeFrequencyBands()
	{
	}

	private void BandBuffer()
	{
	}
}
