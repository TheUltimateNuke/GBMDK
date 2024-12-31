using UnityEngine;

namespace Utils
{
	public class JointData
	{
		public enum JointType
		{
			Fixed = 0,
			Hinge = 1,
			Configurable = 2
		}

		public JointType jointType;

		public Rigidbody connectedBody;

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

		public static JointData CreateInstance(Joint oldJoint)
		{
			return null;
		}

		public static Joint CreateJointFromOtherJoint(Joint joint, GameObject gameObject)
		{
			return null;
		}

		public static Joint CreateJointFromData(JointData jointData, GameObject gameObject)
		{
			return null;
		}
	}
}
