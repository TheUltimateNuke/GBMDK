using Audio;
using UnityEngine;

public class SurfaceOrAirDragEmitter : MonoBehaviour
{
	public AudioClip airDragSound;

	public AudioClip surfaceDragSound;

	private Rigidbody _rigidbody;

	private bool onSurface;

	private AudioController.PooledAudioSource surfaceDragAudioSource;

	private AudioController.PooledAudioSource airDragAudioSource;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnCollisionExit(Collision collision)
	{
	}
}
