using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		public enum WaterMode
		{
			Simple = 0,
			Reflective = 1,
			Refractive = 2
		}

		public WaterMode waterMode;

		public bool disablePixelLights;

		public int textureSize;

		public float clipPlaneOffset;

		public LayerMask reflectLayers;

		public LayerMask refractLayers;

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

		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}
	}
}
