using UnityEngine;

namespace GB.Game
{
	public class KillVolumeEvent
	{
		public bool Used;

		public KillVolumeChecker Checker;

		public KillVolume Volume;

		public Collider Collider;

		public bool IsFalling;

		public bool IsDespawn;

		public void Reset(KillVolume volume, Collider collider, bool isFalling, bool isDespawn)
		{
		}
	}
}
