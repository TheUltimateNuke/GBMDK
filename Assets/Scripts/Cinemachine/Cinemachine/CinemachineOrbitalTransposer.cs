using System;
using Cinemachine.Utility;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[AddComponentMenu(null)]
	[SaveDuringPlay]
	public class CinemachineOrbitalTransposer : CinemachineTransposer
	{
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Heading
		{
			[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
			public enum HeadingDefinition
			{
				PositionDelta = 0,
				Velocity = 1,
				TargetForward = 2,
				WorldForward = 3
			}

			[Tooltip("How 'forward' is defined.  The camera will be placed by default behind the target.  PositionDelta will consider 'forward' to be the direction in which the target is moving.")]
			[FormerlySerializedAs("m_HeadingDefinition")]
			public HeadingDefinition m_Definition;

			[Range(0f, 10f)]
			[Tooltip("Size of the velocity sampling window for target heading filter.  This filters out irregularities in the target's movement.  Used only if deriving heading from target's movement (PositionDelta or Velocity)")]
			public int m_VelocityFilterStrength;

			[FormerlySerializedAs("m_HeadingBias")]
			[Tooltip("Where the camera is placed when the X-axis value is zero.  This is a rotation in degrees around the Y axis.  When this value is 0, the camera will be placed behind the target.  Nonzero offsets will rotate the zero position around the target.")]
			[Range(-180f, 180f)]
			public float m_Bias;

			public Heading(HeadingDefinition def, int filterStrength, float bias)
			{
				m_Definition = default(HeadingDefinition);
				m_VelocityFilterStrength = 0;
				m_Bias = 0f;
			}
		}

		internal delegate float UpdateHeadingDelegate(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up);

		[Tooltip("The definition of Forward.  Camera will follow behind.")]
		[Space]
		[OrbitalTransposerHeadingProperty]
		public Heading m_Heading;

		[Tooltip("Automatic heading recentering.  The settings here defines how the camera will reposition itself in the absence of player input.")]
		public AxisState.Recentering m_RecenterToTargetHeading;

		[AxisStateProperty]
		[Tooltip("Heading Control.  The settings here control the behaviour of the camera in response to the player's input.")]
		public AxisState m_XAxis;

		[FormerlySerializedAs("m_Radius")]
		[HideInInspector]
		[SerializeField]
		private float m_LegacyRadius;

		[SerializeField]
		[HideInInspector]
		[FormerlySerializedAs("m_HeightOffset")]
		private float m_LegacyHeightOffset;

		[SerializeField]
		[FormerlySerializedAs("m_HeadingBias")]
		[HideInInspector]
		private float m_LegacyHeadingBias;

		[NoSaveDuringPlay]
		[HideInInspector]
		public bool m_HeadingIsSlave;

		internal UpdateHeadingDelegate HeadingUpdater;

		private Vector3 m_LastTargetPosition;

		private HeadingTracker mHeadingTracker;

		private Rigidbody m_TargetRigidBody;

		private Transform m_PreviousTarget;

		private Vector3 m_LastCameraPosition;

		private float m_LastHeading;

		public override bool RequiresUserInput => false;

		protected override void OnValidate()
		{
		}

		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis)
		{
			return 0f;
		}

		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis, ref AxisState.Recentering recentering, bool isLive)
		{
			return 0f;
		}

		private void OnEnable()
		{
		}

		public void UpdateInputAxisProvider()
		{
		}

		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		public override void ForceCameraPosition(Vector3 pos, Quaternion rot)
		{
		}

		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams)
		{
			return false;
		}

		public float GetAxisClosestValue(Vector3 cameraPos, Vector3 up)
		{
			return 0f;
		}

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		public override Vector3 GetTargetCameraPosition(Vector3 worldUp)
		{
			return default(Vector3);
		}

		private float GetTargetHeading(float currentHeading, Quaternion targetOrientation)
		{
			return 0f;
		}
	}
}
