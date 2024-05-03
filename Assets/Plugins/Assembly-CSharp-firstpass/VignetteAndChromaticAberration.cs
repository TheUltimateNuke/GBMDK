using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
public class VignetteAndChromaticAberration : PostEffectsBase
{
	public enum AberrationMode
	{
		Simple = 0,
		Advanced = 1
	}

	public AberrationMode mode;

	public float intensity;

	public float chromaticAberration;

	public float axialAberration;

	public float blur;

	public float blurSpread;

	public float luminanceDependency;

	public float blurDistance;

	public Shader vignetteShader;

	private Material vignetteMaterial;

	public Shader separableBlurShader;

	private Material separableBlurMaterial;

	public Shader chromAberrationShader;

	private Material chromAberrationMaterial;

	public override bool CheckResources()
	{
		return false;
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
