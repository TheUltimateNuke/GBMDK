using System;
using UnityEngine;

namespace SuperGenius.Scripts.Fracture.Utilities
{
	[Serializable]
	public class ShardJoint
	{
		public JointType JointType;

		public FixedJointData FixedJointData;

		public ConfigurableJointData ConfigurableJointData;

		public void CreateJoint(GameObject go, Rigidbody rigidbody)
		{
		}
	}
}
