using Cinemachine.Utility;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[SaveDuringPlay]
	[AddComponentMenu(null)]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public class CinemachineFramingTransposer : CinemachineComponentBase
	{
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum FramingMode
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2,
			None = 3
		}

		public enum AdjustmentMode
		{
			ZoomOnly = 0,
			DollyOnly = 1,
			DollyThenZoom = 2
		}

		[Tooltip("Offset from the Follow Target object (in target-local co-ordinates).  The camera will attempt to frame the point which is the target's position plus this offset.  Use it to correct for cases when the target's origin is not the point of interest for the camera.")]
		public Vector3 m_TrackedObjectOffset;

		[Tooltip("This setting will instruct the composer to adjust its target offset based on the motion of the target.  The composer will look at a point where it estimates the target will be this many seconds into the future.  Note that this setting is sensitive to noisy animation, and can amplify the noise, resulting in undesirable camera jitter.  If the camera jitters unacceptably when the target is in motion, turn down this setting, or animate the target more smoothly.")]
		[Space]
		[Range(0f, 1f)]
		public float m_LookaheadTime;

		[Range(0f, 30f)]
		[Tooltip("Controls the smoothness of the lookahead algorithm.  Larger values smooth out jittery predictions and also increase prediction lag")]
		public float m_LookaheadSmoothing;

		[Tooltip("If checked, movement along the Y axis will be ignored for lookahead calculations")]
		public bool m_LookaheadIgnoreY;

		[Tooltip("How aggressively the camera tries to maintain the offset in the X-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's x-axis offset.  Larger numbers give a more heavy slowly responding camera.  Using different settings per axis can yield a wide range of camera behaviors.")]
		[Range(0f, 20f)]
		[Space]
		public float m_XDamping;

		[Tooltip("How aggressively the camera tries to maintain the offset in the Y-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's y-axis offset.  Larger numbers give a more heavy slowly responding camera.  Using different settings per axis can yield a wide range of camera behaviors.")]
		[Range(0f, 20f)]
		public float m_YDamping;

		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to maintain the offset in the Z-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's z-axis offset.  Larger numbers give a more heavy slowly responding camera.  Using different settings per axis can yield a wide range of camera behaviors.")]
		public float m_ZDamping;

		[Tooltip("If set, damping will apply  only to target motion, but not to camera rotation changes.  Turn this on to get an instant response when the rotation changes.  ")]
		public bool m_TargetMovementOnly;

		[Space]
		[Range(-0.5f, 1.5f)]
		[Tooltip("Horizontal screen position for target. The camera will move to position the tracked object here.")]
		public float m_ScreenX;

		[Tooltip("Vertical screen position for target, The camera will move to position the tracked object here.")]
		[Range(-0.5f, 1.5f)]
		public float m_ScreenY;

		[Tooltip("The distance along the camera axis that will be maintained from the Follow target")]
		public float m_CameraDistance;

		[Tooltip("Camera will not move horizontally if the target is within this range of the position.")]
		[Range(0f, 2f)]
		[Space]
		public float m_DeadZoneWidth;

		[Tooltip("Camera will not move vertically if the target is within this range of the position.")]
		[Range(0f, 2f)]
		public float m_DeadZoneHeight;

		[Tooltip("The camera will not move along its z-axis if the Follow target is within this distance of the specified camera distance")]
		[FormerlySerializedAs("m_DistanceDeadZoneSize")]
		public float m_DeadZoneDepth;

		[Space]
		[Tooltip("If checked, then then soft zone will be unlimited in size.")]
		public bool m_UnlimitedSoftZone;

		[Range(0f, 2f)]
		[Tooltip("When target is within this region, camera will gradually move horizontally to re-align towards the desired position, depending on the damping speed.")]
		public float m_SoftZoneWidth;

		[Range(0f, 2f)]
		[Tooltip("When target is within this region, camera will gradually move vertically to re-align towards the desired position, depending on the damping speed.")]
		public float m_SoftZoneHeight;

		[Range(-0.5f, 0.5f)]
		[Tooltip("A non-zero bias will move the target position horizontally away from the center of the soft zone.")]
		public float m_BiasX;

		[Range(-0.5f, 0.5f)]
		[Tooltip("A non-zero bias will move the target position vertically away from the center of the soft zone.")]
		public float m_BiasY;

		[Tooltip("Force target to center of screen when this camera activates.  If false, will clamp target to the edges of the dead zone")]
		public bool m_CenterOnActivate;

		[Space]
		[Tooltip("What screen dimensions to consider when framing.  Can be Horizontal, Vertical, or both")]
		[FormerlySerializedAs("m_FramingMode")]
		public FramingMode m_GroupFramingMode;

		[Tooltip("How to adjust the camera to get the desired framing.  You can zoom, dolly in/out, or do both.")]
		public AdjustmentMode m_AdjustmentMode;

		[Tooltip("The bounding box of the targets should occupy this amount of the screen space.  1 means fill the whole screen.  0.5 means fill half the screen, etc.")]
		public float m_GroupFramingSize;

		[Tooltip("The maximum distance toward the target that this behaviour is allowed to move the camera.")]
		public float m_MaxDollyIn;

		[Tooltip("The maximum distance away the target that this behaviour is allowed to move the camera.")]
		public float m_MaxDollyOut;

		[Tooltip("Set this to limit how close to the target the camera can get.")]
		public float m_MinimumDistance;

		[Tooltip("Set this to limit how far from the target the camera can get.")]
		public float m_MaximumDistance;

		[Tooltip("If adjusting FOV, will not set the FOV lower than this.")]
		[Range(1f, 179f)]
		public float m_MinimumFOV;

		[Range(1f, 179f)]
		[Tooltip("If adjusting FOV, will not set the FOV higher than this.")]
		public float m_MaximumFOV;

		[Tooltip("If adjusting Orthographic Size, will not set it lower than this.")]
		public float m_MinimumOrthoSize;

		[Tooltip("If adjusting Orthographic Size, will not set it higher than this.")]
		public float m_MaximumOrthoSize;

		private const float kMinimumCameraDistance = 0.01f;

		private const float kMinimumGroupSize = 0.01f;

		private Vector3 m_PreviousCameraPosition;

		internal PositionPredictor m_Predictor;

		private bool m_InheritingPosition;

		private float m_prevFOV;

		private Quaternion m_prevRotation;

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

		public override bool IsValid => false;

		public override CinemachineCore.Stage Stage => default(CinemachineCore.Stage);

		public override bool BodyAppliesAfterAim => false;

		public Vector3 TrackedPoint { get; private set; }

		public Bounds LastBounds { get; private set; }

		public Matrix4x4 LastBoundsMatrix { get; private set; }

		private void OnValidate()
		{
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

		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams)
		{
			return false;
		}

		private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect)
		{
			return default(Rect);
		}

		private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect)
		{
			return default(Vector3);
		}

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		private float GetTargetHeight(Vector2 boundsSize)
		{
			return 0f;
		}

		private Vector3 ComputeGroupBounds(ICinemachineTargetGroup group, ref CameraState curState)
		{
			return default(Vector3);
		}

		private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation)
		{
			return default(Bounds);
		}
	}
}
