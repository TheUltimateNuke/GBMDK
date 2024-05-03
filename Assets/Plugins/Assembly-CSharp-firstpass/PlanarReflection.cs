using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(WaterBase))]
[ExecuteInEditMode]
public class PlanarReflection : MonoBehaviour
{
	public LayerMask reflectionMask;

	public bool reflectSkybox;

	public Color clearColor;

	public string reflectionSampler;

	public float clipPlaneOffset;

	private Vector3 oldpos;

	private Camera reflectionCamera;

	private Material sharedMaterial;

	private Dictionary<Camera, bool> helperCameras;

	public void Start()
	{
	}

	private Camera CreateReflectionCameraFor(Camera cam)
	{
		return null;
	}

	private void SetStandardCameraParameter(Camera cam, LayerMask mask)
	{
	}

	private RenderTexture CreateTextureFor(Camera cam)
	{
		return null;
	}

	public void RenderHelpCameras(Camera currentCam)
	{
	}

	public void LateUpdate()
	{
	}

	public void WaterTileBeingRendered(Transform tr, Camera currentCam)
	{
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	private void RenderReflectionFor(Camera cam, Camera reflectCamera)
	{
	}

	private void SaneCameraSettings(Camera helperCam)
	{
	}

	private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
	{
		return default(Matrix4x4);
	}

	private static float sgn(float a)
	{
		return 0f;
	}

	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default(Vector4);
	}
}
