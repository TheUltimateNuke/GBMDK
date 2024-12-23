using UnityEngine;

public class JK3DForceFieldSettings : JK3DMeshMod
{
	public Color Border;

	public Color Middle;

	[Range(0.01f, 0.99f)]
	public float TopBeamIntensity;

	[Range(0.01f, 0.99f)]
	public float BottomBeamIntensity;

	public float ForceFieldActive;
}
