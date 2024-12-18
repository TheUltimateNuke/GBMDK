using UnityEngine;

public class GlassShardCleanup : MonoBehaviour
{
	public GameObject shardParticles;

	private float minDelay;

	private float maxDelay;

	private float delay;

	private float timer;

	private Rigidbody _CachedRigidbody;

	private bool canShatter;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnCollisionStay(Collision collision)
	{
	}
}
