using UnityEngine;

namespace GB.Networking.Utils.Spawn
{
	public abstract class GBMultiSpawnPoint : GBSpawnPoint
	{
		protected int _lockCount;

		public override bool Locked
		{
			set
			{
			}
		}

		public override Vector3 Position => default(Vector3);

		public override Quaternion Rotation => default(Quaternion);

		public override int Used => 0;

		protected abstract Vector3 ResultingPosition(int i);

		protected abstract Quaternion ResultingRotation(int i);
	}
}
