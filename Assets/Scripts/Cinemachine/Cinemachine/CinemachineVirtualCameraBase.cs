using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[SaveDuringPlay]
	public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera, ISerializationCallbackReceiver
	{
		public enum StandbyUpdateMode
		{
			Never = 0,
			Always = 1,
			RoundRobin = 2
		}

		public enum BlendHint
		{
			None = 0,
			SphericalPosition = 1,
			CylindricalPosition = 2,
			ScreenSpaceAimWhenTargetsDiffer = 3
		}

		[Serializable]
		public struct TransitionParams
		{
			[FormerlySerializedAs("m_PositionBlending")]
			[Tooltip("Hint for blending positions to and from this virtual camera")]
			public BlendHint m_BlendHint;

			[Tooltip("When this virtual camera goes Live, attempt to force the position to be the same as the current position of the Unity Camera")]
			public bool m_InheritPosition;

			[Tooltip("This event fires when the virtual camera goes Live")]
			public CinemachineBrain.VcamActivatedEvent m_OnCameraLive;
		}

		[NoSaveDuringPlay]
		[SerializeField]
		[HideInInspector]
		public string[] m_ExcludedPropertiesInInspector;

		[SerializeField]
		[NoSaveDuringPlay]
		[HideInInspector]
		public CinemachineCore.Stage[] m_LockStageInInspector;

		private int m_ValidatingStreamVersion;

		private bool m_OnValidateCalled;

		[NoSaveDuringPlay]
		[SerializeField]
		[HideInInspector]
		private int m_StreamingVersion;

		[Tooltip("The priority will determine which camera becomes active based on the state of other cameras and this camera.  Higher numbers have greater priority.")]
		[NoSaveDuringPlay]
		public int m_Priority;

		internal int m_ActivationId;

		[NonSerialized]
		public float FollowTargetAttachment;

		[NonSerialized]
		public float LookAtTargetAttachment;

		[Tooltip("When the virtual camera is not live, this is how often the virtual camera will be updated.  Set this to tune for performance. Most of the time Never is fine, unless the virtual camera is doing shot evaluation.")]
		public StandbyUpdateMode m_StandbyUpdate;

		private bool m_WasStarted;

		private bool mSlaveStatusUpdated;

		private CinemachineVirtualCameraBase m_parentVcam;

		private int m_QueuePriority;

		private Transform m_CachedFollowTarget;

		private CinemachineVirtualCameraBase m_CachedFollowTargetVcam;

		private ICinemachineTargetGroup m_CachedFollowTargetGroup;

		private Transform m_CachedLookAtTarget;

		private CinemachineVirtualCameraBase m_CachedLookAtTargetVcam;

		private ICinemachineTargetGroup m_CachedLookAtTargetGroup;

		public int ValidatingStreamVersion
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		internal List<CinemachineExtension> mExtensions { get; private set; }

		public string Name => null;

		public virtual string Description => null;

		public int Priority
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public GameObject VirtualCameraGameObject => null;

		public bool IsValid => false;

		public abstract CameraState State { get; }

		public ICinemachineCamera ParentCamera => null;

		public abstract Transform LookAt { get; set; }

		public abstract Transform Follow { get; set; }

		public virtual bool PreviousStateIsValid { get; set; }

		public bool FollowTargetChanged { get; private set; }

		public bool LookAtTargetChanged { get; private set; }

		public ICinemachineTargetGroup AbstractFollowTargetGroup => null;

		public CinemachineVirtualCameraBase FollowTargetAsVcam => null;

		public ICinemachineTargetGroup AbstractLookAtTargetGroup => null;

		public CinemachineVirtualCameraBase LookAtTargetAsVcam => null;

		public virtual float GetMaxDampTime()
		{
			return 0f;
		}

		public float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime)
		{
			return 0f;
		}

		public Vector3 DetachedFollowTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime)
		{
			return default(Vector3);
		}

		public Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime)
		{
			return default(Vector3);
		}

		public float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime)
		{
			return 0f;
		}

		public Vector3 DetachedLookAtTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime)
		{
			return default(Vector3);
		}

		public Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime)
		{
			return default(Vector3);
		}

		public virtual void AddExtension(CinemachineExtension extension)
		{
		}

		public virtual void RemoveExtension(CinemachineExtension extension)
		{
		}

		protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime)
		{
		}

		protected void InvokePrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState newState, float deltaTime)
		{
		}

		protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
			return false;
		}

		protected void ApplyPositionBlendMethod(ref CameraState state, BlendHint hint)
		{
		}

		public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return false;
		}

		public void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime);

		public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnTransformParentChanged()
		{
		}

		protected virtual void Start()
		{
		}

		internal virtual bool RequiresUserInput()
		{
			return false;
		}

		internal void EnsureStarted()
		{
		}

		public AxisState.IInputAxisProvider GetInputAxisProvider()
		{
			return null;
		}

		protected virtual void OnValidate()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		private void UpdateSlaveStatus()
		{
		}

		public Transform ResolveLookAt(Transform localLookAt)
		{
			return null;
		}

		public Transform ResolveFollow(Transform localFollow)
		{
			return null;
		}

		private void UpdateVcamPoolStatus()
		{
		}

		public void MoveToTopOfPrioritySubqueue()
		{
		}

		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot)
		{
		}

		protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend)
		{
			return null;
		}

		protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens)
		{
			return default(CameraState);
		}

		private void InvalidateCachedTargets()
		{
		}

		protected void UpdateTargetCache()
		{
		}

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
		}

		protected internal virtual void LegacyUpgrade(int streamedVersion)
		{
		}

		internal virtual void OnBeforeSerialize()
		{
		}

        void ISerializationCallbackReceiver.OnBeforeSerialize()
        {
            throw new NotImplementedException();
        }

        public void OnAfterDeserialize()
        {
            throw new NotImplementedException();
        }
    }
}
