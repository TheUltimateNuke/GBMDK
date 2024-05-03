using UnityEngine;

[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class BlurOptimized : PostEffectsBase
{
	public enum BlurType
	{
		StandardGauss = 0,
		SgxGauss = 1
	}

	[Range(0f, 2f)]
	public int downsample;

	[Range(0f, 10f)]
	public float blurSize;

	[Range(1f, 4f)]
	public int blurIterations;

	public BlurType blurType;

	public Shader blurShader;

	private Material blurMaterial;

	public override bool CheckResources()
	{
		return false;
	}

	public void OnDisable()
	{
	}

	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
