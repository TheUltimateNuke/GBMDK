using Femur;
using UnityEngine;

public class FallingAudioEmitter : MonoBehaviour
{
	public AudioClip fallSound;

	private AudioSource fallSoundSource;

	private Actor actor;

	private Transform thisTransform;

	private Rigidbody thisRigidbody;

	private float fadeInVolume;

	private float maxVolume;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Setup()
	{
	}
}
