using UnityEngine;

namespace Cinemachine
{
	public class CinemachineBlend
	{
		public ICinemachineCamera CamA;

		public ICinemachineCamera CamB;

		public AnimationCurve BlendCurve;

		public float TimeInBlend;

		public float Duration;

		public float BlendWeight => 0f;

		public bool IsValid => false;

		public bool IsComplete => false;

		public string Description => null;

		public CameraState State => default(CameraState);

		public bool Uses(ICinemachineCamera cam)
		{
			return false;
		}

		public CinemachineBlend(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t)
		{
		}

		public void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}
	}
}
