using UnityEngine;

public class PipeGasJet : MonoBehaviour
{
	public float startTimer;

	public float minFireDelay;

	public float maxFireDelay;

	public Vector3 axis;

	private Transform cachedTransform;

	private ParticleSystem cachedParticleSystem;

	private bool active;

	public float timer;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
