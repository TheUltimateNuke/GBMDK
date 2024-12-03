using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineExternalCamera.html")]
	[AddComponentMenu("Cinemachine/CinemachineExternalCamera")]
	[RequireComponent(typeof(Camera))]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class CinemachineExternalCamera : CinemachineVirtualCameraBase
	{
		[VcamTargetProperty]
		[NoSaveDuringPlay]
		[Tooltip("The object that the camera is looking at.  Setting this will improve the quality of the blends to and from this camera")]
		public Transform m_LookAt;

		private Camera m_Camera;

		private CameraState m_State;

		[Tooltip("Hint for blending positions to and from this virtual camera")]
		[FormerlySerializedAs("m_PositionBlending")]
		public BlendHint m_BlendHint;

		public override CameraState State => default(CameraState);

		public override Transform LookAt
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Transform Follow { get; set; }

		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}
	}
}
