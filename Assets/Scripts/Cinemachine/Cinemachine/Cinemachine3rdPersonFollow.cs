using UnityEngine;

namespace Cinemachine
{
	[SaveDuringPlay]
	[AddComponentMenu(null)]
	public class Cinemachine3rdPersonFollow : CinemachineComponentBase
	{
		[Tooltip("How responsively the camera tracks the target.  Each axis (camera-local) can have its own setting.  Value is the approximate time it takes the camera to catch up to the target's new position.  Smaller values give a more rigid effect, larger values give a squishier one")]
		public Vector3 Damping;

		[Header("Rig")]
		[Tooltip("Position of the shoulder pivot relative to the Follow target origin.  This offset is in target-local space")]
		public Vector3 ShoulderOffset;

		[Tooltip("Vertical offset of the hand in relation to the shoulder.  Arm length will affect the follow target's screen position when the camera rotates vertically")]
		public float VerticalArmLength;

		[Tooltip("Specifies which shoulder (left, right, or in-between) the camera is on")]
		[Range(0f, 1f)]
		public float CameraSide;

		[Tooltip("How far baehind the hand the camera will be placed")]
		public float CameraDistance;

		[Tooltip("Camera will avoid obstacles on these layers")]
		[Header("Obstacles")]
		public LayerMask CameraCollisionFilter;

		[TagField]
		[Tooltip("Obstacles with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
		public string IgnoreTag;

		[Range(0f, 1f)]
		[Tooltip("Specifies how close the camera can get to obstacles")]
		public float CameraRadius;

		[Tooltip("How gradually the camera moves to correct for occlusions.  Higher numbers will move the camera more gradually.")]
		[Range(0f, 10f)]
		public float DampingIntoCollision;

		[Tooltip("How gradually the camera returns to its normal position after having been corrected by the built-in collision resolution system.  Higher numbers will move the camera more gradually back to normal.")]
		[Range(0f, 10f)]
		public float DampingFromCollision;

		private Vector3 m_PreviousFollowTargetPosition;

		private Vector3 m_DampingCorrection;

		private float m_CamPosCollisionCorrection;

		public override bool IsValid => false;

		public override CinemachineCore.Stage Stage => default(CinemachineCore.Stage);

		private void OnValidate()
		{
		}

		private void Reset()
		{
		}

		private void OnDestroy()
		{
		}

		public override float GetMaxDampTime()
		{
			return 0f;
		}

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		private void PositionCamera(ref CameraState curState, float deltaTime)
		{
		}

		public void GetRigPositions(out Vector3 root, out Vector3 shoulder, out Vector3 hand)
		{
			root = default(Vector3);
			shoulder = default(Vector3);
			hand = default(Vector3);
		}

		internal static Quaternion GetHeading(Quaternion targetRot, Vector3 up)
		{
			return default(Quaternion);
		}

		private void GetRawRigPositions(Vector3 root, Quaternion targetRot, Quaternion heading, out Vector3 shoulder, out Vector3 hand)
		{
			shoulder = default(Vector3);
			hand = default(Vector3);
		}

		private Vector3 ResolveCollisions(Vector3 root, Vector3 tip, float deltaTime, float cameraRadius, ref float collisionCorrection)
		{
			return default(Vector3);
		}
	}
}
