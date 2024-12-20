using System;
using UnityEngine;

namespace SuperGenius.Scripts.Fracture.Utilities
{
	[Serializable]
	public class ConfigurableJointData : JointData
	{
		public Vector3 secondaryAxis;

		public ConfigurableJointMotion xMotion;

		public ConfigurableJointMotion yMotion;

		public ConfigurableJointMotion zMotion;

		public ConfigurableJointMotion angularXMotion;

		public ConfigurableJointMotion angularYMotion;

		public ConfigurableJointMotion angularZMotion;

		public SoftJointLimitSpring linearLimitSpring;

		public SoftJointLimitSpring angularXLimitSpring;

		public SoftJointLimitSpring angularYZLimitSpring;

		public SoftJointLimit linearLimit;

		public SoftJointLimit lowAngularXLimit;

		public SoftJointLimit highAngularXLimit;

		public SoftJointLimit angularYLimit;

		public SoftJointLimit angularZLimit;

		public Vector3 targetPosition;

		public Vector3 targetVelocity;

		public JointDrive xDrive;

		public JointDrive yDrive;

		public JointDrive zDrive;

		public Quaternion targetRotation;

		public Vector3 targetAngularVelocity;

		public RotationDriveMode rotationDriveMode;

		public JointDrive angularXDrive;

		public JointDrive angularYZDrive;

		public JointDrive slerpDrive;

		public JointProjectionMode projectionMode;

		public float projectionDistance;

		public float projectionAngle;

		public bool configuredInWorldSpace;

		public bool swapBodies;

		public override void CreateFixedJoint(GameObject go, Rigidbody connectedRigidbody)
		{
		}
	}
}
