using System;
using UnityEngine;

namespace Cinemachine
{
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[ExcludeFromPreset]
	[AddComponentMenu("Cinemachine/CinemachineBlendListCamera")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineBlendListCamera.html")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public class CinemachineBlendListCamera : CinemachineVirtualCameraBase
	{
		[Serializable]
		public struct Instruction
		{
			[Tooltip("The virtual camera to activate when this instruction becomes active")]
			public CinemachineVirtualCameraBase m_VirtualCamera;

			[Tooltip("How long to wait (in seconds) before activating the next virtual camera in the list (if any)")]
			public float m_Hold;

			[CinemachineBlendDefinitionProperty]
			[Tooltip("How to blend to the next virtual camera in the list (if any)")]
			public CinemachineBlendDefinition m_Blend;
		}

		[Tooltip("Default object for the camera children to look at (the aim target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
		[NoSaveDuringPlay]
		[VcamTargetProperty]
		public Transform m_LookAt;

		[Tooltip("Default object for the camera children wants to move with (the body target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
		[NoSaveDuringPlay]
		[VcamTargetProperty]
		public Transform m_Follow;

		[Tooltip("When enabled, the current child camera and blend will be indicated in the game window, for debugging")]
		public bool m_ShowDebugText;

		[Tooltip("When enabled, the child vcams will cycle indefinitely instead of just stopping at the last one")]
		public bool m_Loop;

		[HideInInspector]
		[SerializeField]
		[NoSaveDuringPlay]
		internal CinemachineVirtualCameraBase[] m_ChildCameras;

		[Tooltip("The set of instructions for enabling child cameras.")]
		public Instruction[] m_Instructions;

		private ICinemachineCamera m_TransitioningFrom;

		private CameraState m_State;

		private float mActivationTime;

		private int mCurrentInstruction;

		private CinemachineBlend mActiveBlend;

		public override string Description => null;

		public ICinemachineCamera LiveChild { get; set; }

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

		public override Transform Follow
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CinemachineVirtualCameraBase[] ChildCameras => null;

		public bool IsBlending => false;

		private void Reset()
		{
		}

		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return false;
		}

		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		public override void ForceCameraPosition(Vector3 pos, Quaternion rot)
		{
		}

		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void OnTransformChildrenChanged()
		{
		}

		private void OnGuiHandler()
		{
		}

		private void InvalidateListOfChildren()
		{
		}

		private void UpdateListOfChildren()
		{
		}

		internal void ValidateInstructions()
		{
		}

		private void AdvanceCurrentInstruction(float deltaTime)
		{
		}
	}
}
