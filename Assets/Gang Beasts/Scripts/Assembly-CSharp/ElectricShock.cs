using UnityEngine;

public class ElectricShock : MonoBehaviour
{
	public bool active;

	public int minJumps;

	public int maxJumps;

	public float jumpRange;

	public float searchRange;

	public float knockback;

	public float endKnockback;

	public float damage;

	public AudioClip zapSound;

	public LayerMask targetLayerMask;

	public ElectricShockPool electricShockPool;

	private Vector3 lastJump;

	private Vector3 thisJump;

	private Rigidbody thisRigidbody;

	private int jumpCount;

	private int totalJumps;

	private Collider[] results;

	private ParticleSystem trail;

	private bool grounded;

	private Vector3 origin;

	private void Start()
	{
	}

	public void CalculateJumps(Vector3 startPosition)
	{
	}

	private void EndJump()
	{
	}

	private void Jump()
	{
	}

	private void Jump(bool endJump)
	{
	}

	private void Reset()
	{
	}

	private void BlindJump()
	{
	}

	private void TargetedJump(Collider target, bool endJump)
	{
	}
}
