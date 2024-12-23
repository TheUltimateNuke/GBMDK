using CoreNet.StateSync.Routers;
using GB.Networking.Router;
using UnityEngine;

public class PhysicAudioEmitter : MonoBehaviour
{
	public enum ImpactState
	{
		None = 0,
		Soft = 1,
		Hard = 2
	}

	public static readonly int MAX_COLLISION_POINTS;

	public PhysicsAudioData audioData;

	private float enableTimer;

	private float retriggerDelay;

	private AudioClip currentImpactClip;

	private Vector3[] collisionPoints;

	[SerializeField]
	public RigidbodySyncRouter Sync;

	[SerializeField]
	public PhysicsAudioRouter AudioRouter;

	[HideInInspector]
	public ImpactState currentImpactState;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	public void OnReset()
	{
	}

	public void UpdateImpl()
	{
	}

	private void ImpactSoundCheck(Collision collision)
	{
	}

	public void ImpactSoundCheck(float magnitude, Vector3 position, Vector3[] contactPoints = null, int count = 0)
	{
	}

	private void SetImpactState(ImpactState newState)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
