using Audio;
using UnityEngine;

public class wheelAxle : MonoBehaviour
{
	public Vector3 axis;

	public float force;

	public float targetVelocity;

	public bool breakOff;

	public HingeJoint joint;

	[SerializeField]
	private AudioClip wheelLoopClip;

	private AudioController.PooledAudioSource pooledSource;

	private Transform thisTransform;

	private Rigidbody thisRigidbody;

	private float cachedStartingTargetVelocity;

	public float velocity;

	public bool gameStarted;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnGameStarted()
	{
	}

	private void FixedUpdate()
	{
	}
}
