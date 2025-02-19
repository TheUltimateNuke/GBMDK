using UnityEngine;

[AddComponentMenu("Image Effects/Sonic Ether/SESSAO")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class SESSAO : MonoBehaviour
{
	private Material material;

	public bool visualizeSSAO;

	private Texture2D ditherTexture;

	private Texture2D ditherTextureSmall;

	private bool skipThisFrame;

	[Range(0.02f, 5f)]
	public float radius;

	[Range(-0.2f, 0.5f)]
	public float bias;

	[Range(0.1f, 3f)]
	public float bilateralDepthTolerance;

	[Range(1f, 5f)]
	public float zThickness;

	[Range(0.5f, 5f)]
	public float occlusionIntensity;

	[Range(1f, 6f)]
	public float sampleDistributionCurve;

	[Range(0f, 1f)]
	public float colorBleedAmount;

	[Range(0.1f, 3f)]
	public float brightnessThreshold;

	public float drawDistance;

	public float drawDistanceFadeSize;

	public bool reduceSelfBleeding;

	public bool useDownsampling;

	public bool halfSampling;

	public bool preserveDetails;

	[HideInInspector]
	public Camera attachedCamera;

	private object initChecker;

	private void CheckInit()
	{
	}

	private void Init()
	{
	}

	private void Cleanup()
	{
	}

	private void SetupDitherTextureSmall()
	{
	}

	private void SetupDitherTexture()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
