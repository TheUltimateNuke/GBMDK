using System;
using UnityEngine;

[Serializable]
public class AudioBlast
{
	public AudioClip[] clips;

	public float volume;

	public float pitch;

	public float minDistance;

	public float maxDistance;
}
