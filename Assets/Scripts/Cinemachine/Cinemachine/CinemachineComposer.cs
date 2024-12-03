using Cinemachine.Utility;
using UnityEngine;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	[AddComponentMenu(null)]
	public class CinemachineComposer : CinemachineComponentBase
	{
		private struct FovCache
		{
			public Rect mFovSoftGuideRect;

			public Rect mFovHardGuideRect;

			public float mFovH;

			public float mFov;

			private float mOrthoSizeOverDistance;

			private float mAspect;

			private Rect mSoftGuideRect;

			private Rect mHardGuideRect;

			public void UpdateCache(LensSettings lens, Rect softGuide, Rect hardGuide, float targetDistance)
			{
			}

			private Rect ScreenToFOV(Rect rScreen, float fov, float fovH, float aspect)
			{
				return default(Rect);
			}
		}

		[Tooltip("Target offset from the target object's center in target-local space. Use this to fine-tune the tracking target position when the desired area is not the tracked object's center.")]
		public Vector3 m_TrackedObjectOffset;

		[Range(0f, 1f)]
		[Tooltip("This setting will instruct the composer to adjust its target offset based on the motion of the target.  The composer will look at a point where it estimates the target will be this many seconds into the future.  Note that this setting is sensitive to noisy animation, and can amplify the noise, resulting in undesirable camera jitter.  If the camera jitters unacceptably when the target is in motion, turn down this setting, or animate the target more smoothly.")]
		[Space]
		public float m_LookaheadTime;

		[Tooltip("Controls the smoothness of the lookahead algorithm.  Larger values smooth out jittery predictions and also increase prediction lag")]
		[Range(0f, 30f)]
		public float m_LookaheadSmoothing;

		[Tooltip("If checked, movement along the Y axis will be ignored for lookahead calculations")]
		public bool m_LookaheadIgnoreY;

		[Space]
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to follow the target in the screen-horizontal direction. Small numbers are more responsive, rapidly orienting the camera to keep the target in the dead zone. Larger numbers give a more heavy slowly responding camera. Using different vertical and horizontal settings can yield a wide range of camera behaviors.")]
		public float m_HorizontalDamping;

		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to follow the target in the screen-vertical direction. Small numbers are more responsive, rapidly orienting the camera to keep the target in the dead zone. Larger numbers give a more heavy slowly responding camera. Using different vertical and horizontal settings can yield a wide range of camera behaviors.")]
		public float m_VerticalDamping;

		[Tooltip("Horizontal screen position for target. The camera will rotate to position the tracked object here.")]
		[Space]
		[Range(-0.5f, 1.5f)]
		public float m_ScreenX;

		[Range(-0.5f, 1.5f)]
		[Tooltip("Vertical screen position for target, The camera will rotate to position the tracked object here.")]
		public float m_ScreenY;

		[Range(0f, 2f)]
		[Tooltip("Camera will not rotate horizontally if the target is within this range of the position.")]
		public float m_DeadZoneWidth;

		[Tooltip("Camera will not rotate vertically if the target is within this range of the position.")]
		[Range(0f, 2f)]
		public float m_DeadZoneHeight;

		[Range(0f, 2f)]
		[Tooltip("When target is within this region, camera will gradually rotate horizontally to re-align towards the desired position, depending on the damping speed.")]
		public float m_SoftZoneWidth;

		[Tooltip("When target is within this region, camera will gradually rotate vertically to re-align towards the desired position, depending on the damping speed.")]
		[Range(0f, 2f)]
		public float m_SoftZoneHeight;

		[Range(-0.5f, 0.5f)]
		[Tooltip("A non-zero bias will move the target position horizontally away from the center of the soft zone.")]
		public float m_BiasX;

		[Range(-0.5f, 0.5f)]
		[Tooltip("A non-zero bias will move the target position vertically away from the center of the soft zone.")]
		public float m_BiasY;

		[Tooltip("Force target to center of screen when this camera activates.  If false, will clamp target to the edges of the dead zone")]
		public bool m_CenterOnActivate;

		private Vector3 m_CameraPosPrevFrame;

		private Vector3 m_LookAtPrevFrame;

		private Vector2 m_ScreenOffsetPrevFrame;

		private Quaternion m_CameraOrientationPrevFrame;

		internal PositionPredictor m_Predictor;

		private FovCache mCache;

		public override bool IsValid => false;

		public override CinemachineCore.Stage Stage => default(CinemachineCore.Stage);

		public Vector3 TrackedPoint { get; private set; }

		internal Rect SoftGuideRect
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		internal Rect HardGuideRect
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		protected virtual Vector3 GetLookAtPointAndSetTrackedPoint(Vector3 lookAt, Vector3 up, float deltaTime)
		{
			return default(Vector3);
		}

		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		public override void ForceCameraPosition(Vector3 pos, Quaternion rot)
		{
		}

		public override float GetMaxDampTime()
		{
			return 0f;
		}

		public override void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		private void RotateToScreenBounds(ref CameraState state, Rect screenRect, Vector3 trackedPoint, ref Quaternion rigOrientation, float fov, float fovH, float deltaTime)
		{
		}

		private bool ClampVerticalBounds(ref Rect r, Vector3 dir, Vector3 up, float fov)
		{
			return false;
		}
	}
}
