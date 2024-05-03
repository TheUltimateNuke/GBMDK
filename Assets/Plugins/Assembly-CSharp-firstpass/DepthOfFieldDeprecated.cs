using UnityEngine;

[AddComponentMenu("Image Effects/Camera/Depth of Field (deprecated)")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class DepthOfFieldDeprecated : PostEffectsBase
{
	public enum Dof34QualitySetting
	{
		OnlyBackground = 1,
		BackgroundAndForeground = 2
	}

	public enum DofResolution
	{
		High = 2,
		Medium = 3,
		Low = 4
	}

	public enum DofBlurriness
	{
		Low = 1,
		High = 2,
		VeryHigh = 4
	}

	public enum BokehDestination
	{
		Background = 1,
		Foreground = 2,
		BackgroundAndForeground = 3
	}

	private static int SMOOTH_DOWNSAMPLE_PASS;

	private static float BOKEH_EXTRA_BLUR;

	public Dof34QualitySetting quality;

	public DofResolution resolution;

	public bool simpleTweakMode;

	public float focalPoint;

	public float smoothness;

	public float focalZDistance;

	public float focalZStartCurve;

	public float focalZEndCurve;

	private float focalStartCurve;

	private float focalEndCurve;

	private float focalDistance01;

	public Transform objectFocus;

	public float focalSize;

	public DofBlurriness bluriness;

	public float maxBlurSpread;

	public float foregroundBlurExtrude;

	public Shader dofBlurShader;

	private Material dofBlurMaterial;

	public Shader dofShader;

	private Material dofMaterial;

	public bool visualize;

	public BokehDestination bokehDestination;

	private float widthOverHeight;

	private float oneOverBaseSize;

	public bool bokeh;

	public bool bokehSupport;

	public Shader bokehShader;

	public Texture2D bokehTexture;

	public float bokehScale;

	public float bokehIntensity;

	public float bokehThreshholdContrast;

	public float bokehThreshholdLuminance;

	public int bokehDownsample;

	private Material bokehMaterial;

	private Camera _camera;

	private RenderTexture foregroundTexture;

	private RenderTexture mediumRezWorkTexture;

	private RenderTexture finalDefocus;

	private RenderTexture lowRezWorkTexture;

	private RenderTexture bokehSource;

	private RenderTexture bokehSource2;

	private void CreateMaterials()
	{
	}

	public override bool CheckResources()
	{
		return false;
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private float FocalDistance01(float worldDist)
	{
		return 0f;
	}

	private int GetDividerBasedOnQuality()
	{
		return 0;
	}

	private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
	{
		return 0;
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
	}

	private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
	}

	private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
	{
	}

	private void Downsample(RenderTexture from, RenderTexture to)
	{
	}

	private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
	{
	}

	private void ReleaseTextures()
	{
	}

	private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
	{
	}
}
