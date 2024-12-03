using UnityEngine;

namespace CoreNet.StateSync.Syncs
{
	public class RigidbodySync : TransformSync
	{
		protected bool _sync;

		private Rigidbody _rigidbody;

		[SerializeField]
		private bool _ignoreKinematicChanges;

		[SerializeField]
		private bool _forceKinematicOnClient;

		private bool testedForRB;

		public bool Syncing => false;

		public override Vector3 CurrentPosition => default(Vector3);

		public override Quaternion CurrentRotation => default(Quaternion);

		public Rigidbody RigidbodyTest => null;

		public override void Init()
		{
		}

		public override void SetSyncing(bool syncing, bool isServer)
		{
		}

		private void ConfigureRigidbody(bool isKinematic)
		{
		}

		protected override void SetPosition(Vector3 position, bool teleport = false)
		{
		}

		protected override void SetRotation(Quaternion rotation, bool teleport = false)
		{
		}
	}
}
