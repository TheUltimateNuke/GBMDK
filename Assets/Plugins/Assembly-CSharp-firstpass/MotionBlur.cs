using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Blur/Motion Blur (Color Accumulation)")]
[RequireComponent(typeof(Camera))]
public class MotionBlur : ImageEffectBase
{
	public float blurAmount;

	public bool extraBlur;

	private RenderTexture accumTexture;

	protected override void Start()
	{
	}

	protected override void OnDisable()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
