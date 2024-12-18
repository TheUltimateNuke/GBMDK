using UnityEngine;

public struct AudioDataResult
{
	public AudioClip clip;

	public float volume;

	public float pitch;

	public static implicit operator bool(AudioDataResult result)
	{
		return false;
	}
}
