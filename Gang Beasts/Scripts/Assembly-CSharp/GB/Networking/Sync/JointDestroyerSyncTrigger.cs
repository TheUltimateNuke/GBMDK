using CoreNet.StateSync.Triggers;
using UnityEngine;

namespace GB.Networking.Sync
{
	public class JointDestroyerSyncTrigger : BaseSyncTrigger
	{
		[SerializeField]
		private Joint[] Joints;

		[SerializeField]
		private bool instantSync;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public override void OverrideSync(bool state)
		{
		}
	}
}
