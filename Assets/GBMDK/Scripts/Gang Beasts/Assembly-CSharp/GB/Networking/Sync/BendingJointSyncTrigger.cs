using UnityEngine;

namespace GB.Networking.Sync
{
	public class BendingJointSyncTrigger : ReconnectableJointSyncTrigger
	{
		[SerializeField]
		private Joint _bendJointLink;

		protected override void OnEnable()
		{
		}

		public override void RecreateJoint()
		{
		}
	}
}
