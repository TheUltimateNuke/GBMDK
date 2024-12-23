using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GB.View.Controllers
{
	public class XRController : ViewController
	{
		public bool ForceBlockVRGUIInput;

		public static Action OnRigCreated;

		[SerializeField]
		private float CameraNearClipOverride;

		private float platformForwardOffset;

		private GameObject _CameraObject;

		private Transform _centreTransform;

		private Camera _currentCamera;

		public float BlinkTime;

		private bool _changingPoint;

		private bool _gameStarted;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public void Awake()
		{
		}

		private void RegenerateCamera(Scene arg0, Scene arg1)
		{
		}

		private void ReplaceCamera()
		{
		}

		private void OnDestroy()
		{
		}

		private void MovementAllow()
		{
		}

		private void MovementBlock()
		{
		}

		public void LateUpdate()
		{
		}

		public override Vector3 GetForward()
		{
			return default(Vector3);
		}

		public override Vector3 GetUIPosition(float forwardMultiplier)
		{
			return default(Vector3);
		}

		public override Quaternion GetUIRotation()
		{
			return default(Quaternion);
		}

		protected override void AddEffects()
		{
		}

		protected override void AddGraphicalElement()
		{
		}

		protected override void SetGraphicsLimiters()
		{
		}

		private void UpdateVR()
		{
		}

		private void UpdateVRPosition()
		{
		}

		private void SetCameraEyeInfo(Camera eye, Camera camera)
		{
		}

		public void UpdateAnchor()
		{
		}

		public void MoveToNext()
		{
		}

		public void MoveToPrev()
		{
		}

		public override void DoChange(Action move)
		{
		}

		public override void CompleteChange()
		{
		}

		public void FinishedMove()
		{
		}
	}
}
