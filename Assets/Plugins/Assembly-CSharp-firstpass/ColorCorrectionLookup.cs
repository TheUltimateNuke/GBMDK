using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
public class ColorCorrectionLookup : PostEffectsBase
{
	public Shader shader;

	private Material material;

	public Texture3D converted3DLut;

	public string basedOnTempTex;

	public override bool CheckResources()
	{
		return false;
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetIdentityLut()
	{
	}

	public bool ValidDimensions(Texture2D tex2d)
	{
		return false;
	}

	public void Convert(Texture2D temp2DTex, string path)
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
