using UnityEngine;

public class LiquidData : ScriptableObject
{
	public float density;

	public float drag;

	public float angularDrag;

	public float maxVelocity;

	public float maxAngularVelocity;

	[Space]
	public bool allowSinking;

	public float sinkSpeed;

	public float riseSpeed;

	[Space]
	public GameObject ripple;

	public float rippleEmitDelay;

	[Space]
	public GameObject smallSplash;

	public GameObject largeSplash;

	public float splashEmitDelay;

	public float smallSplashThreshold;

	public float smallSplashAngularThreshold;

	public float largeSplashThreshold;

	public float largeSplashAngularThreshold;

	[Space]
	public GameObject bubble;

	public float bubbleEmitDelay;
}
