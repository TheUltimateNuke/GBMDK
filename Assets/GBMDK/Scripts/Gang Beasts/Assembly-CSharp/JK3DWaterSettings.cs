using UnityEngine;

public class JK3DWaterSettings : JK3DMeshMod
{
	public float speedX;

	public float speedY;

	[Range(0f, 1f)]
	public float fresnelIntensity;

	[Range(0f, 1f)]
	public float rippleIntensity;

	[Range(0f, 1f)]
	public float alpha;
}
