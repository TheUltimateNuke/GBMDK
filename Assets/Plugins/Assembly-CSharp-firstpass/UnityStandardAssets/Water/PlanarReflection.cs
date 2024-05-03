using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace UnityStandardAssets.Water
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class PlanarReflection : MonoBehaviour
	{
		public LayerMask reflectionMask;

		public bool reflectSkybox;

		public Color clearColor;

		public string reflectionSampler;

		public float clipPlaneOffset;

		private Vector3 m_Oldpos;

		private Camera m_ReflectionCamera;

		private Material m_SharedMaterial;

		private Dictionary<Camera, bool> m_HelperCameras;

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

		private void RenderReflectionFor(ScriptableRenderContext context, Camera[] cameras)
		{
		}

		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		private void SaneCameraSettings(Camera helperCam)
		{
		}

		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		private static float Sgn(float a)
		{
			return 0f;
		}

		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}
	}
}
