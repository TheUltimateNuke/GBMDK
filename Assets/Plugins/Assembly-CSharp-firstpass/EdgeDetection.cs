using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Edge Detection/Edge Detection")]
public class EdgeDetection : PostEffectsBase
{
	public enum EdgeDetectMode
	{
		TriangleDepthNormals = 0,
		RobertsCrossDepthNormals = 1,
		SobelDepth = 2,
		SobelDepthThin = 3,
		TriangleLuminance = 4
	}

	public EdgeDetectMode mode;

	public float sensitivityDepth;

	public float sensitivityNormals;

	public float lumThreshhold;

	public float edgeExp;

	public float sampleDist;

	public float edgesOnly;

	public Color edgesOnlyBgColor;

	public Shader edgeDetectShader;

	private Material edgeDetectMaterial;

	private EdgeDetectMode oldMode;

	public override bool CheckResources()
	{
		return false;
	}

	private new void Start()
	{
	}

	private void SetCameraFlag()
	{
	}

	private void OnEnable()
	{
	}

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
