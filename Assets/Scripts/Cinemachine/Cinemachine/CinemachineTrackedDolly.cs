using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[SaveDuringPlay]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[AddComponentMenu(null)]
	public class CinemachineTrackedDolly : CinemachineComponentBase
	{
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum CameraUpMode
		{
			Default = 0,
			Path = 1,
			PathNoRoll = 2,
			FollowTarget = 3,
			FollowTargetNoRoll = 4
		}

		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct AutoDolly
		{
			[Tooltip("If checked, will enable automatic dolly, which chooses a path position that is as close as possible to the Follow target.  Note: this can have significant performance impact")]
			public bool m_Enabled;

			[Tooltip("Offset, in current position units, from the closest point on the path to the follow target")]
			public float m_PositionOffset;

			[Tooltip("Search up to this many waypoints on either side of the current position.  Use 0 for Entire path.")]
			public int m_SearchRadius;

			[FormerlySerializedAs("m_StepsPerSegment")]
			[Tooltip("We search between waypoints by dividing the segment into this many straight pieces.  he higher the number, the more accurate the result, but performance is proportionally slower for higher numbers")]
			public int m_SearchResolution;

			public AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment)
			{
				m_Enabled = false;
				m_PositionOffset = 0f;
				m_SearchRadius = 0;
				m_SearchResolution = 0;
			}
		}

		[Tooltip("The path to which the camera will be constrained.  This must be non-null.")]
		public CinemachinePathBase m_Path;

		[Tooltip("The position along the path at which the camera will be placed.  This can be animated directly, or set automatically by the Auto-Dolly feature to get as close as possible to the Follow target.  The value is interpreted according to the Position Units setting.")]
		public float m_PathPosition;

		[Tooltip("How to interpret Path Position.  If set to Path Units, values are as follows: 0 represents the first waypoint on the path, 1 is the second, and so on.  Values in-between are points on the path in between the waypoints.  If set to Distance, then Path Position represents distance along the path.")]
		public CinemachinePathBase.PositionUnits m_PositionUnits;

		[Tooltip("Where to put the camera relative to the path position.  X is perpendicular to the path, Y is up, and Z is parallel to the path.  This allows the camera to be offset from the path itself (as if on a tripod, for example).")]
		public Vector3 m_PathOffset;

		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to maintain its position in a direction perpendicular to the path.  Small numbers are more responsive, rapidly translating the camera to keep the target's x-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
		public float m_XDamping;

		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to maintain its position in the path-local up direction.  Small numbers are more responsive, rapidly translating the camera to keep the target's y-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
		public float m_YDamping;

		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to maintain its position in a direction parallel to the path.  Small numbers are more responsive, rapidly translating the camera to keep the target's z-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
		public float m_ZDamping;

		[Tooltip("How to set the virtual camera's Up vector.  This will affect the screen composition, because the camera Aim behaviours will always try to respect the Up direction.")]
		public CameraUpMode m_CameraUp;

		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to track the target rotation's X angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
		public float m_PitchDamping;

		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to track the target rotation's Y angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
		public float m_YawDamping;

		[Tooltip("How aggressively the camera tries to track the target rotation's Z angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
		[Range(0f, 20f)]
		public float m_RollDamping;

		[Tooltip("Controls how automatic dollying occurs.  A Follow target is necessary to use this feature.")]
		public AutoDolly m_AutoDolly;

		private float m_PreviousPathPosition;

		private Quaternion m_PreviousOrientation;

		private Vector3 m_PreviousCameraPosition;

		public override bool IsValid => false;

		public override CinemachineCore.Stage Stage => default(CinemachineCore.Stage);

		private Vector3 AngularDamping => default(Vector3);

		public override float GetMaxDampTime()
		{
			return 0f;
		}

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		private Quaternion GetCameraOrientationAtPathPoint(Quaternion pathOrientation, Vector3 up)
		{
			return default(Quaternion);
		}
	}
}
