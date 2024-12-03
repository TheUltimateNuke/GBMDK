using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[AddComponentMenu("Cinemachine/CinemachineBrain")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineBrainProperties.html")]
	[SaveDuringPlay]
	public class CinemachineBrain : MonoBehaviour
	{
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum UpdateMethod
		{
			FixedUpdate = 0,
			LateUpdate = 1,
			SmartUpdate = 2,
			ManualUpdate = 3
		}

		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum BrainUpdateMethod
		{
			FixedUpdate = 0,
			LateUpdate = 1
		}

		[Serializable]
		public class BrainEvent : UnityEvent<CinemachineBrain>
		{
		}

		[Serializable]
		public class VcamActivatedEvent : UnityEvent<ICinemachineCamera, ICinemachineCamera>
		{
		}

		private class BrainFrame
		{
			public int id;

			public CinemachineBlend blend;

			public CinemachineBlend workingBlend;

			public BlendSourceVirtualCamera workingBlendSource;

			public float deltaTimeOverride;

			public float blendStartPosition;

			public bool Active => false;
		}

		[CompilerGenerated]
		private sealed class _003CAfterPhysics_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CinemachineBrain _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CAfterPhysics_003Ed__33(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[Tooltip("When enabled, the current camera and blend will be indicated in the game window, for debugging")]
		public bool m_ShowDebugText;

		[Tooltip("When enabled, the camera's frustum will be shown at all times in the scene view")]
		public bool m_ShowCameraFrustum;

		[Tooltip("When enabled, the cameras will always respond in real-time to user input and damping, even if the game is running in slow motion")]
		public bool m_IgnoreTimeScale;

		[Tooltip("If set, this object's Y axis will define the worldspace Up vector for all the virtual cameras.  This is useful for instance in top-down game environments.  If not set, Up is worldspace Y.  Setting this appropriately is important, because Virtual Cameras don't like looking straight up or straight down.")]
		public Transform m_WorldUpOverride;

		[Tooltip("The update time for the vcams.  Use FixedUpdate if all your targets are animated during FixedUpdate (e.g. RigidBodies), LateUpdate if all your targets are animated during the normal Update loop, and SmartUpdate if you want Cinemachine to do the appropriate thing on a per-target basis.  SmartUpdate is the recommended setting")]
		public UpdateMethod m_UpdateMethod;

		[Tooltip("The update time for the Brain, i.e. when the blends are evaluated and the brain's transform is updated")]
		public BrainUpdateMethod m_BlendUpdateMethod;

		[CinemachineBlendDefinitionProperty]
		[Tooltip("The blend that is used in cases where you haven't explicitly defined a blend between two Virtual Cameras")]
		public CinemachineBlendDefinition m_DefaultBlend;

		[Tooltip("This is the asset that contains custom settings for blends between specific virtual cameras in your scene")]
		public CinemachineBlenderSettings m_CustomBlends;

		private Camera m_OutputCamera;

		[Tooltip("This event will fire whenever a virtual camera goes live and there is no blend")]
		public BrainEvent m_CameraCutEvent;

		[Tooltip("This event will fire whenever a virtual camera goes live.  If a blend is involved, then the event will fire on the first frame of the blend.")]
		public VcamActivatedEvent m_CameraActivatedEvent;

		private static ICinemachineCamera mSoloCamera;

		private Coroutine mPhysicsCoroutine;

		private int m_LastFrameUpdated;

		private WaitForFixedUpdate mWaitForFixedUpdate;

		private List<BrainFrame> mFrameStack;

		private int mNextFrameId;

		private CinemachineBlend mCurrentLiveCameras;

		private static readonly AnimationCurve mDefaultLinearAnimationCurve;

		private ICinemachineCamera mActiveCameraPreviousFrame;

		private GameObject mActiveCameraPreviousFrameGameObject;

		public Camera OutputCamera => null;

		public static ICinemachineCamera SoloCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 DefaultWorldUp => default(Vector3);

		public ICinemachineCamera ActiveVirtualCamera => null;

		public bool IsBlending => false;

		public CinemachineBlend ActiveBlend => null;

		public CameraState CurrentCameraState { get; private set; }

		public static Color GetSoloGUIColor()
		{
			return default(Color);
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		private void OnSceneUnloaded(Scene scene)
		{
		}

		private void Start()
		{
		}

		private void OnGuiHandler()
		{
		}

		[IteratorStateMachine(typeof(_003CAfterPhysics_003Ed__33))]
		private IEnumerator AfterPhysics()
		{
			return null;
		}

		private void LateUpdate()
		{
		}

		public void ManualUpdate()
		{
		}

		private float GetEffectiveDeltaTime(bool fixedDelta)
		{
			return 0f;
		}

		private void UpdateVirtualCameras(CinemachineCore.UpdateFilter updateFilter, float deltaTime)
		{
		}

		private static ICinemachineCamera DeepCamBFromBlend(CinemachineBlend blend)
		{
			return null;
		}

		public bool IsLiveInBlend(ICinemachineCamera vcam)
		{
			return false;
		}

		private int GetBrainFrame(int withId)
		{
			return 0;
		}

		public int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime)
		{
			return 0;
		}

		public void ReleaseCameraOverride(int overrideId)
		{
		}

		private void ProcessActiveCamera(float deltaTime)
		{
		}

		private void UpdateFrame0(float deltaTime)
		{
		}

		public void ComputeCurrentBlend(ref CinemachineBlend outputBlend, int numTopLayersToExclude)
		{
		}

		public bool IsLive(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return false;
		}

		private ICinemachineCamera TopCameraFromPriorityQueue()
		{
			return null;
		}

		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey)
		{
			return default(CinemachineBlendDefinition);
		}

		private void PushStateToUnityCamera(ref CameraState state)
		{
		}
	}
}
