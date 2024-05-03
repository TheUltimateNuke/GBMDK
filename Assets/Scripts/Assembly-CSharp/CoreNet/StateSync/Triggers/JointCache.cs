using GB.Networking.StateSync.Syncs;

namespace CoreNet.StateSync.Triggers
{
	internal struct JointCache
	{
		public float cachedBreakForce;

		public float cachedBreakTorque;

		public JointCache(BreakableJointSync.JointInvulnerables joint):this()
		{
		}
	}
}
