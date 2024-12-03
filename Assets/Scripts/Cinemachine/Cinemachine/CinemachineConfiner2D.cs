using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineConfiner2D.html")]
	[AddComponentMenu(null)]
	[SaveDuringPlay]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class CinemachineConfiner2D : CinemachineExtension
	{
		private class VcamExtraState
		{
			public Vector3 m_PreviousDisplacement;

			public Vector3 m_DampedDisplacement;

			public ConfinerOven.BakedSolution m_BakedSolution;

			public CinemachineVirtualCameraBase m_vcam;
		}

		private struct ShapeCache
		{
			public ConfinerOven m_confinerOven;

			public List<List<Vector2>> m_OriginalPath;

			public Matrix4x4 m_DeltaWorldToBaked;

			public Matrix4x4 m_DeltaBakedToWorld;

			private float m_aspectRatio;

			private float m_maxWindowSize;

			internal float m_maxComputationTimePerFrameInSeconds;

			private Matrix4x4 m_bakedToWorld;

			private Collider2D m_boundingShape2D;

			public void Invalidate()
			{
			}

			public bool ValidateCache(Collider2D boundingShape2D, float maxWindowSize, float aspectRatio, out bool confinerStateChanged)
			{
				confinerStateChanged = default(bool);
				return false;
			}

			private bool IsValid(in Collider2D boundingShape2D, in float aspectRatio, in float maxOrthoSize)
			{
				return false;
			}

			private void CalculateDeltaTransformationMatrix()
			{
			}
		}

		[Tooltip("The 2D shape within which the camera is to be contained.  Can be a 2D polygon or 2D composite collider.")]
		public Collider2D m_BoundingShape2D;

		[Tooltip("Damping applied around corners to avoid jumps.  Higher numbers are more gradual.")]
		[Range(0f, 5f)]
		public float m_Damping;

		[Tooltip("To optimize computation and memory costs, set this to the largest view size that the camera is expected to have.  The confiner will not compute a polygon cache for frustum sizes larger than this.  This refers to the size in world units of the frustum at the confiner plane (for orthographic cameras, this is just the orthographic size).  If set to 0, then this parameter is ignored and a polygon cache will be calculated for all potential window sizes.")]
		public float m_MaxWindowSize;

		private float m_MaxComputationTimePerFrameInSeconds;

		private const float k_cornerAngleTreshold = 10f;

		private ShapeCache m_shapeCache;

		public void InvalidateCache()
		{
		}

		public bool ValidateCache(float cameraAspectRatio)
		{
			return false;
		}

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		private float CalculateHalfFrustumHeight(in CameraState state, in float cameraPosLocalZ)
		{
			return 0f;
		}

		private void OnValidate()
		{
		}

		private void Reset()
		{
		}
	}
}
