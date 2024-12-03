using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[AddComponentMenu(null)]
	[SaveDuringPlay]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineConfiner.html")]
	public class CinemachineConfiner : CinemachineExtension
	{
		public enum Mode
		{
			Confine2D = 0,
			Confine3D = 1
		}

		private class VcamExtraState
		{
			public Vector3 m_previousDisplacement;

			public float confinerDisplacement;
		}

		[Tooltip("The confiner can operate using a 2D bounding shape or a 3D bounding volume")]
		public Mode m_ConfineMode;

		[Tooltip("The volume within which the camera is to be contained")]
		public Collider m_BoundingVolume;

		[Tooltip("The 2D shape within which the camera is to be contained")]
		public Collider2D m_BoundingShape2D;

		private Collider2D m_BoundingShape2DCache;

		[Tooltip("If camera is orthographic, screen edges will be confined to the volume.  If not checked, then only the camera center will be confined")]
		public bool m_ConfineScreenEdges;

		[Tooltip("How gradually to return the camera to the bounding volume if it goes beyond the borders.  Higher numbers are more gradual.")]
		[Range(0f, 10f)]
		public float m_Damping;

		private List<List<Vector2>> m_pathCache;

		private int m_pathTotalPointCount;

		public bool IsValid => false;

		public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam)
		{
			return false;
		}

		public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam)
		{
			return 0f;
		}

		private void OnValidate()
		{
		}

		protected override void ConnectToVcam(bool connect)
		{
		}

		public override float GetMaxDampTime()
		{
			return 0f;
		}

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		public void InvalidatePathCache()
		{
		}

		private bool ValidatePathCache()
		{
			return false;
		}

		private Vector3 ConfinePoint(Vector3 camPos)
		{
			return default(Vector3);
		}

		private Vector3 ConfineScreenEdges(ref CameraState state)
		{
			return default(Vector3);
		}
	}
}
