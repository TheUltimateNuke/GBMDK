using UnityEngine;

public class AmplifyAudioZone : MonoBehaviour
{
	public AudioSource audioSource;

	public float minVolume;

	public float maxVolume;

	public float step;

	private bool trigger;

	private float volume;

	private void OnTriggerStay(Collider collider)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
