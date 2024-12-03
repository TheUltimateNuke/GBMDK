using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	[ExecuteAlways]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[DisallowMultipleComponent]
	[ExcludeFromPreset]
	[AddComponentMenu("Cinemachine/CinemachineStateDrivenCamera")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineStateDrivenCamera.html")]
	public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase
	{
		[Serializable]
		public struct Instruction
		{
			[Tooltip("The full hash of the animation state")]
			public int m_FullHash;

			[Tooltip("The virtual camera to activate when the animation state becomes active")]
			public CinemachineVirtualCameraBase m_VirtualCamera;

			[Tooltip("How long to wait (in seconds) before activating the virtual camera. This filters out very short state durations")]
			public float m_ActivateAfter;

			[Tooltip("The minimum length of time (in seconds) to keep a virtual camera active")]
			public float m_MinDuration;
		}

		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.Undoc)]
		internal struct ParentHash
		{
			public int m_Hash;

			public int m_ParentHash;

			public ParentHash(int h, int p)
			{
				m_Hash = 0;
				m_ParentHash = 0;
			}
		}

		private struct HashPair
		{
			public int parentHash;

			public int hash;
		}

		[Tooltip("Default object for the camera children to look at (the aim target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
		[VcamTargetProperty]
		[NoSaveDuringPlay]
		public Transform m_LookAt;

		[VcamTargetProperty]
		[Tooltip("Default object for the camera children wants to move with (the body target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
		[NoSaveDuringPlay]
		public Transform m_Follow;

		[Space]
		[Tooltip("The state machine whose state changes will drive this camera's choice of active child")]
		[NoSaveDuringPlay]
		public Animator m_AnimatedTarget;

		[NoSaveDuringPlay]
		[Tooltip("Which layer in the target state machine to observe")]
		public int m_LayerIndex;

		[Tooltip("When enabled, the current child camera and blend will be indicated in the game window, for debugging")]
		public bool m_ShowDebugText;

		[NoSaveDuringPlay]
		[HideInInspector]
		[SerializeField]
		internal CinemachineVirtualCameraBase[] m_ChildCameras;

		[Tooltip("The set of instructions associating virtual cameras with states.  These instructions are used to choose the live child at any given moment")]
		public Instruction[] m_Instructions;

		[CinemachineBlendDefinitionProperty]
		[Tooltip("The blend which is used if you don't explicitly define a blend between two Virtual Camera children")]
		public CinemachineBlendDefinition m_DefaultBlend;

		[Tooltip("This is the asset which contains custom settings for specific child blends")]
		public CinemachineBlenderSettings m_CustomBlends;

		[HideInInspector]
		[SerializeField]
		internal ParentHash[] m_ParentHash;

		private ICinemachineCamera m_TransitioningFrom;

		private CameraState m_State;

		private Dictionary<AnimationClip, List<HashPair>> mHashCache;

		private float mActivationTime;

		private Instruction mActiveInstruction;

		private float mPendingActivationTime;

		private Instruction mPendingInstruction;

		private CinemachineBlend mActiveBlend;

		private Dictionary<int, int> mInstructionDictionary;

		private Dictionary<int, int> mStateParentLookup;

		private List<AnimatorClipInfo> m_clipInfoList;

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

		public void OnTransformChildrenChanged()
		{
		}

		private void OnGuiHandler()
		{
		}

		public static int CreateFakeHash(int parentHash, AnimationClip clip)
		{
			return 0;
		}

		private int LookupFakeHash(int parentHash, AnimationClip clip)
		{
			return 0;
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

		private CinemachineVirtualCameraBase ChooseCurrentCamera()
		{
			return null;
		}

		private int GetClipHash(int hash, List<AnimatorClipInfo> clips)
		{
			return 0;
		}

		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey)
		{
			return default(CinemachineBlendDefinition);
		}
	}
}
