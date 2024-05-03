using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Water : MonoBehaviour
{
	public enum WaterMode
	{
		Simple = 0,
		Reflective = 1,
		Refractive = 2
	}

	public WaterMode m_WaterMode;

	public bool m_DisablePixelLights;

	public int m_TextureSize;

	public float m_ClipPlaneOffset;

	public LayerMask m_ReflectLayers;

	public LayerMask m_RefractLayers;

	private Dictionary<Camera, Camera> m_ReflectionCameras;

	private Dictionary<Camera, Camera> m_RefractionCameras;

	private RenderTexture m_ReflectionTexture;

	private RenderTexture m_RefractionTexture;

	private WaterMode m_HardwareWaterSupport;

	private int m_OldReflectionTextureSize;

	private int m_OldRefractionTextureSize;

	private static bool s_InsideWater;

	public void OnWillRenderObject()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void UpdateCameraModes(Camera src, Camera dest)
	{
	}

	private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
	{
		reflectionCamera = null;
		refractionCamera = null;
	}

	private WaterMode GetWaterMode()
	{
		return default(WaterMode);
	}

	private WaterMode FindHardwareWaterSupport()
	{
		return default(WaterMode);
	}

	private static float sgn(float a)
	{
		return 0f;
	}

	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default(Vector4);
	}

	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}
}
