using UnityEngine;

public class GeneralAudioData : ScriptableObject
{
	public AudioClip[] clips;

	public float minVolumeModifier;

	public float maxVolumeModifier;

	public float minPitchModifier;

	public float maxPitchModifier;

	public AudioDataResult GetClip()
	{
		return default(AudioDataResult);
	}
}
