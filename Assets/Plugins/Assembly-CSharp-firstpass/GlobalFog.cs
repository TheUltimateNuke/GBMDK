using UnityEngine;

[AddComponentMenu("Image Effects/Rendering/Global Fog")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
internal class GlobalFog : PostEffectsBase
{
	private float CAMERA_NEAR;

	private float CAMERA_FAR;

	private float CAMERA_FOV;

	private float CAMERA_ASPECT_RATIO;

	public bool distanceFog;

	public bool heightFog;

	public float height;

	[Range(0.001f, 10f)]
	public float heightDensity;

	public float startDistance;

	public Shader fogShader;

	private Material fogMaterial;

	public override bool CheckResources()
	{
		return false;
	}

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
	{
	}
}
