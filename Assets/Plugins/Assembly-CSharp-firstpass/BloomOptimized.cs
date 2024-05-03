using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
internal class BloomOptimized : PostEffectsBase
{
	public enum Resolution
	{
		Low = 0,
		High = 1
	}

	public enum BlurType
	{
		Standard = 0,
		Sgx = 1
	}

	[Range(0f, 1.5f)]
	public float threshhold;

	[Range(0f, 2.5f)]
	public float intensity;

	[Range(0.25f, 5.5f)]
	public float blurSize;

	private Resolution resolution;

	[Range(1f, 4f)]
	public int blurIterations;

	public BlurType blurType;

	public Shader fastBloomShader;

	private Material fastBloomMaterial;

	public override bool CheckResources()
	{
		return false;
	}

	private void OnDisable()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
