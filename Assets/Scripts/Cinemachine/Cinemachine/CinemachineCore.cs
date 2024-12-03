using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	public sealed class CinemachineCore
	{
		public enum Stage
		{
			Body = 0,
			Aim = 1,
			Noise = 2,
			Finalize = 3
		}

		public delegate float AxisInputDelegate(string axisName);

		public delegate CinemachineBlendDefinition GetBlendOverrideDelegate(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, MonoBehaviour owner);

		private class UpdateStatus
		{
			public int lastUpdateFrame;

			public int lastUpdateFixedFrame;

			public UpdateTracker.UpdateClock lastUpdateMode;

			public float lastUpdateDeltaTime;
		}

		internal enum UpdateFilter
		{
			Fixed = 0,
			Late = 1,
			Smart = 8,
			SmartFixed = 8,
			SmartLate = 9
		}

		public static readonly int kStreamingVersion;

		public static readonly string kVersionString;

		private static CinemachineCore sInstance;

		public static bool sShowHiddenObjects;

		public static AxisInputDelegate GetInputAxis;

		public static float UniformDeltaTimeOverride;

		public static float CurrentTimeOverride;

		public static GetBlendOverrideDelegate GetBlendOverride;

		public static CinemachineBrain.BrainEvent CameraUpdatedEvent;

		public static CinemachineBrain.BrainEvent CameraCutEvent;

		private List<CinemachineBrain> mActiveBrains;

		private List<CinemachineVirtualCameraBase> mActiveCameras;

		private bool m_ActiveCamerasAreSorted;

		private int m_ActivationSequence;

		private List<List<CinemachineVirtualCameraBase>> mAllCameras;

		private CinemachineVirtualCameraBase mRoundRobinVcamLastFrame;

		private static float s_LastUpdateTime;

		private static int s_FixedFrameCount;

		private Dictionary<CinemachineVirtualCameraBase, UpdateStatus> mUpdateStatus;

		internal UpdateFilter m_CurrentUpdateFilter;

		public static CinemachineCore Instance => null;

		public static float DeltaTime => 0f;

		public static float CurrentTime => 0f;

		public int BrainCount => 0;

		public int VirtualCameraCount => 0;

		public CinemachineBrain GetActiveBrain(int index)
		{
			return null;
		}

		internal void AddActiveBrain(CinemachineBrain brain)
		{
		}

		internal void RemoveActiveBrain(CinemachineBrain brain)
		{
		}

		public CinemachineVirtualCameraBase GetVirtualCamera(int index)
		{
			return null;
		}

		internal void AddActiveCamera(CinemachineVirtualCameraBase vcam)
		{
		}

		internal void RemoveActiveCamera(CinemachineVirtualCameraBase vcam)
		{
		}

		internal void CameraDestroyed(CinemachineVirtualCameraBase vcam)
		{
		}

		internal void CameraEnabled(CinemachineVirtualCameraBase vcam)
		{
		}

		internal void CameraDisabled(CinemachineVirtualCameraBase vcam)
		{
		}

		internal void UpdateAllActiveVirtualCameras(int layerMask, Vector3 worldUp, float deltaTime)
		{
		}

		internal void UpdateVirtualCamera(CinemachineVirtualCameraBase vcam, Vector3 worldUp, float deltaTime)
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule()
		{
		}

		private static Transform GetUpdateTarget(CinemachineVirtualCameraBase vcam)
		{
			return null;
		}

		internal UpdateTracker.UpdateClock GetVcamUpdateStatus(CinemachineVirtualCameraBase vcam)
		{
			return default(UpdateTracker.UpdateClock);
		}

		public bool IsLive(ICinemachineCamera vcam)
		{
			return false;
		}

		public bool IsLiveInBlend(ICinemachineCamera vcam)
		{
			return false;
		}

		public void GenerateCameraActivationEvent(ICinemachineCamera vcam, ICinemachineCamera vcamFrom)
		{
		}

		public void GenerateCameraCutEvent(ICinemachineCamera vcam)
		{
		}

		public CinemachineBrain FindPotentialTargetBrain(CinemachineVirtualCameraBase vcam)
		{
			return null;
		}

		public void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}
	}
}
