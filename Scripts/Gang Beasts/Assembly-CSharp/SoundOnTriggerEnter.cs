using Audio;
using UnityEngine;

public class SoundOnTriggerEnter : MonoBehaviour
{
	private bool canTrigger;

	public AudioClip[] audioClip;

	public float volume;

	public float spatialBlend;

	public float resetDelay;

	public float minDistance;

	public float maxDistance;

	public bool usePlayOneShot;

	public bool checkVelocity;

	public LayerMask layerMask;

	private WaitForSeconds wfs;

	public AudioMixerController.MixerGroup mixerGroup;

	private void OnTriggerEnter(Collider collider)
	{
	}

	private void Reset()
	{
	}
}
