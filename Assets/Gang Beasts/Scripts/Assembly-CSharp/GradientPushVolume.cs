using UnityEngine;

public class GradientPushVolume : PushVolume
{
	[Tooltip("By Default, the gradient is more powerful at the bottom, and weaker at the top. Enable this to flip these values")]
	public bool InvertForce;

	public bool ApplyToSpecifiedPoints;

	public float MinimumForceMultiplier;

	[SerializeField]
	private bool shouldEnableSpashSystem;

	[SerializeField]
	private bool useForceFluctuation;

	[SerializeField]
	private float fluctuationPercentage;

	[SerializeField]
	private float fluctuationPeriod;

	[SerializeField]
	private float minimumVelocitySplash;

	[SerializeField]
	private AudioBlast onEnterSplashSound;

	[SerializeField]
	private GameObject[] splashParticlesInPool;

	private float lastFluxTime;

	private float thisFrameForceFlux;

	protected new void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	protected override void FixedUpdate()
	{
	}

	protected override void ApplyForce(Rigidbody rb, Transform t, PushVolumeClient client)
	{
	}

	private GameObject SelectAvailableParticleSystem()
	{
		return null;
	}
}
