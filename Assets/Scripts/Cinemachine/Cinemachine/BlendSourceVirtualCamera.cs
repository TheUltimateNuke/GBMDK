using UnityEngine;

namespace Cinemachine
{
	internal class BlendSourceVirtualCamera : ICinemachineCamera
	{
		public CinemachineBlend Blend { get; set; }

		public string Name => null;

		public string Description => null;

		public int Priority { get; set; }

		public Transform LookAt { get; set; }

		public Transform Follow { get; set; }

		public CameraState State { get; private set; }

		public GameObject VirtualCameraGameObject => null;

		public bool IsValid => false;

		public ICinemachineCamera ParentCamera => null;

		public BlendSourceVirtualCamera(CinemachineBlend blend)
		{
		}

		public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return false;
		}

		public CameraState CalculateNewState(float deltaTime)
		{
			return default(CameraState);
		}

		public void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		public void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		public void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}
	}
}
