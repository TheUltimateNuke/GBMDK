using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(Collider))]
public class Liquid : NetworkBehaviour
{
	private bool _isEnabled;

	public LiquidData liquid;

	private ParticleSystem ripple;

	private ParticleSystem smallSplash;

	private ParticleSystem largeSplash;

	private ParticleSystem bubble;

	private float rippleEmitTimer;

	private float splashEmitTimer;

	private float bubbleEmitTimer;

	private Collider _collider;

	public bool isEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Start()
	{
	}

	public void Update()
	{
	}

	public void EmitRipple(Vector3 position)
	{
	}

	public void EmitSplash(Vector3 position, float magnitude, float angularMagnitude)
	{
	}

	public void EmitBubble(Vector3 position)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public virtual float GetSurfaceHeight(SimpleBuoyancy buoyancy)
	{
		return 0f;
	}

	private void UNetVersion()
	{
	}

	public override bool OnSerialize(NetworkWriter writer, bool forceAll)
	{
		return false;
	}

	public override void OnDeserialize(NetworkReader reader, bool initialState)
	{
	}

	public override void PreStartClient()
	{
	}
}
