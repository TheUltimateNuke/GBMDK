using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineCollider.html")]
	[DisallowMultipleComponent]
	[SaveDuringPlay]
	[AddComponentMenu(null)]
	[ExecuteAlways]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public class CinemachineCollider : CinemachineExtension
	{
		public enum ResolutionStrategy
		{
			PullCameraForward = 0,
			PreserveCameraHeight = 1,
			PreserveCameraDistance = 2
		}

		private class VcamExtraState
		{
			public Vector3 previousDisplacement;

			public bool targetObscured;

			public float occlusionStartTime;

			public List<Vector3> debugResolutionPath;

			private float m_SmoothedDistance;

			private float m_SmoothedTime;

			public void AddPointToDebugPath(Vector3 p)
			{
			}

			public float ApplyDistanceSmoothing(float distance, float smoothingTime)
			{
				return 0f;
			}

			public void UpdateDistanceSmoothing(float distance)
			{
			}

			public void ResetDistanceSmoothing(float smoothingTime)
			{
			}
		}

		[Tooltip("Objects on these layers will be detected")]
		[Header("Obstacle Detection")]
		public LayerMask m_CollideAgainst;

		[TagField]
		[Tooltip("Obstacles with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
		public string m_IgnoreTag;

		[Tooltip("Objects on these layers will never obstruct view of the target")]
		public LayerMask m_TransparentLayers;

		[Tooltip("Obstacles closer to the target than this will be ignored")]
		public float m_MinimumDistanceFromTarget;

		[Space]
		[Tooltip("When enabled, will attempt to resolve situations where the line of sight to the target is blocked by an obstacle")]
		[FormerlySerializedAs("m_PreserveLineOfSight")]
		public bool m_AvoidObstacles;

		[Tooltip("The maximum raycast distance when checking if the line of sight to this camera's target is clear.  If the setting is 0 or less, the current actual distance to target will be used.")]
		[FormerlySerializedAs("m_LineOfSightFeelerDistance")]
		public float m_DistanceLimit;

		[Tooltip("Don't take action unless occlusion has lasted at least this long.")]
		public float m_MinimumOcclusionTime;

		[Tooltip("Camera will try to maintain this distance from any obstacle.  Try to keep this value small.  Increase it if you are seeing inside obstacles due to a large FOV on the camera.")]
		public float m_CameraRadius;

		[Tooltip("The way in which the Collider will attempt to preserve sight of the target.")]
		public ResolutionStrategy m_Strategy;

		[Range(1f, 10f)]
		[Tooltip("Upper limit on how many obstacle hits to process.  Higher numbers may impact performance.  In most environments, 4 is enough.")]
		public int m_MaximumEffort;

		[Range(0f, 2f)]
		[Tooltip("Smoothing to apply to obstruction resolution.  Nearest camera point is held for at least this long")]
		public float m_SmoothingTime;

		[FormerlySerializedAs("m_Smoothing")]
		[Tooltip("How gradually the camera returns to its normal position after having been corrected.  Higher numbers will move the camera more gradually back to normal.")]
		[Range(0f, 10f)]
		public float m_Damping;

		[Tooltip("How gradually the camera moves to resolve an occlusion.  Higher numbers will move the camera more gradually.")]
		[Range(0f, 10f)]
		public float m_DampingWhenOccluded;

		[Tooltip("If greater than zero, a higher score will be given to shots when the target is closer to this distance.  Set this to zero to disable this feature.")]
		[Header("Shot Evaluation")]
		public float m_OptimalTargetDistance;

		private const float k_PrecisionSlush = 0.001f;

		private RaycastHit[] m_CornerBuffer;

		private const float k_AngleThreshold = 0.1f;

		private static Collider[] s_ColliderBuffer;

		public List<List<Vector3>> DebugPaths => null;

		public bool IsTargetObscured(ICinemachineCamera vcam)
		{
			return false;
		}

		public bool CameraWasDisplaced(ICinemachineCamera vcam)
		{
			return false;
		}

		public float GetCameraDisplacementDistance(ICinemachineCamera vcam)
		{
			return 0f;
		}

		private void OnValidate()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override float GetMaxDampTime()
		{
			return 0f;
		}

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		private Vector3 PreserveLineOfSight(ref CameraState state, ref VcamExtraState extra)
		{
			return default(Vector3);
		}

		private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo)
		{
			return default(Vector3);
		}

		private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref VcamExtraState extra)
		{
			return default(Vector3);
		}

		private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir)
		{
			return false;
		}

		private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos)
		{
			return 0f;
		}

		private static float ClampRayToBounds(Ray ray, float distance, Bounds bounds)
		{
			return 0f;
		}

		private Vector3 RespectCameraRadius(Vector3 cameraPos, Vector3 lookAtPos)
		{
			return default(Vector3);
		}

		private bool CheckForTargetObstructions(CameraState state)
		{
			return false;
		}

		private static bool IsTargetOffscreen(CameraState state)
		{
			return false;
		}
	}
}
