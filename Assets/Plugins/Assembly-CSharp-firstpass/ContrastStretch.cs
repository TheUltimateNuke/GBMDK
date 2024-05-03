using UnityEngine;

[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
[ExecuteInEditMode]
public class ContrastStretch : MonoBehaviour
{
	public float adaptationSpeed;

	public float limitMinimum;

	public float limitMaximum;

	private RenderTexture[] adaptRenderTex;

	private int curAdaptIndex;

	public Shader shaderLum;

	private Material m_materialLum;

	public Shader shaderReduce;

	private Material m_materialReduce;

	public Shader shaderAdapt;

	private Material m_materialAdapt;

	public Shader shaderApply;

	private Material m_materialApply;

	protected Material materialLum => null;

	protected Material materialReduce => null;

	protected Material materialAdapt => null;

	protected Material materialApply => null;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	private void CalculateAdaptation(Texture curTexture)
	{
	}
}
