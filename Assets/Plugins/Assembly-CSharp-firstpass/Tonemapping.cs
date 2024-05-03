using UnityEngine;

[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Color Adjustments/Tonemapping")]
[ExecuteInEditMode]
public class Tonemapping : PostEffectsBase
{
	public enum TonemapperType
	{
		SimpleReinhard = 0,
		UserCurve = 1,
		Hable = 2,
		Photographic = 3,
		OptimizedHejiDawson = 4,
		AdaptiveReinhard = 5,
		AdaptiveReinhardAutoWhite = 6
	}

	public enum AdaptiveTexSize
	{
		Square16 = 0x10,
		Square32 = 0x20,
		Square64 = 0x40,
		Square128 = 0x80,
		Square256 = 0x100,
		Square512 = 0x200,
		Square1024 = 0x400
	}

	public TonemapperType type;

	public AdaptiveTexSize adaptiveTextureSize;

	public AnimationCurve remapCurve;

	private Texture2D curveTex;

	public float exposureAdjustment;

	public float middleGrey;

	public float white;

	public float adaptionSpeed;

	public Shader tonemapper;

	public bool validRenderTextureFormat;

	private Material tonemapMaterial;

	private RenderTexture rt;

	private RenderTextureFormat rtFormat;

	public override bool CheckResources()
	{
		return false;
	}

	public float UpdateCurve()
	{
		return 0f;
	}

	private void OnDisable()
	{
	}

	private bool CreateInternalRenderTexture()
	{
		return false;
	}

	[ImageEffectTransformsToLDR]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
