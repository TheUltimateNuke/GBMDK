using UnityEngine;

namespace Cinemachine
{
	internal class StaticPointVirtualCamera : ICinemachineCamera
	{
		public string Name { get; private set; }

		public string Description => null;

		public int Priority { get; set; }

		public Transform LookAt { get; set; }

		public Transform Follow { get; set; }

		public CameraState State { get; private set; }

		public GameObject VirtualCameraGameObject => null;

		public bool IsValid => false;

		public ICinemachineCamera ParentCamera => null;

		public StaticPointVirtualCamera(CameraState state, string name)
		{
		}

		public void SetState(CameraState state)
		{
		}

		public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return false;
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
