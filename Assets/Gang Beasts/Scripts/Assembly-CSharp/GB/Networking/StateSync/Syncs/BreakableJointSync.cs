using CoreNet.StateSync.Syncs;
using UnityEngine;

namespace GB.Networking.StateSync.Syncs
{
	public class BreakableJointSync : RigidbodySync
	{
		public struct JointInvulnerables
		{
			public float cachedForce;

			public float cachedTorque;

			public Joint cachedJoints;
		}

		[Tooltip("This should be the name of the gameobject under Actor/Colliders")]
		public string ParentTransformName;

		private JointBreakEvent _jointBreakEvent;

		public bool OverrideAutoKinematic;

		private Joint _clientJointCache;

		private JointInvulnerables[] invulnerableJoints;

		private bool Invulnerable { get; set; }

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public JointInvulnerables[] GetJoints()
		{
			return null;
		}

		private void GameStarted()
		{
		}

		public override void SetSyncing(bool syncing, bool isServer)
		{
		}

		private void SetupBreakableJoint(bool syncing)
		{
		}
	}
}
