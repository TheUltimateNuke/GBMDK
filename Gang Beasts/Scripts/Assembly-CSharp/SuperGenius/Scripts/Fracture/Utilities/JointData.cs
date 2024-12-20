using System;
using UnityEngine;

namespace SuperGenius.Scripts.Fracture.Utilities
{
	[Serializable]
	public abstract class JointData
	{
		public Vector3 axis;

		public Vector3 anchor;

		public Vector3 connectedAnchor;

		public bool autoConfigureConnectedAnchor;

		public float breakForce;

		public float breakTorque;

		public bool enableCollision;

		public bool enablePreprocessing;

		public float massScale;

		public float connectedMassScale;

		public abstract void CreateFixedJoint(GameObject go, Rigidbody connectedRigidbosy);

		protected void JointSetup(Joint joint, Rigidbody connectedRigidbody)
		{
		}
	}
}
