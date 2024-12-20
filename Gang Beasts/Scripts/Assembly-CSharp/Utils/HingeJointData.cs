using UnityEngine;

namespace Utils
{
	public class HingeJointData : JointData
	{
		public bool useSpring;

		public JointSpring spring;

		public bool useMotor;

		public JointMotor motor;

		public bool useLimits;

		public JointLimits limits;
	}
}
